using System.Runtime.InteropServices;
using LoadAction = UnityEngine.Rendering.RenderBufferLoadAction;
using StoreAction = UnityEngine.Rendering.RenderBufferStoreAction;

/// <summary>
/// In Unity, the render thread is only accesible in C++ using IssuePluginEvent(). This is a helper
/// class to communicate a C# view with its C++ renderer.
/// </summary>
public class NoesisRenderer
{
    /// <summary>
    /// Registers a view in the render thread
    /// </summary>
    public static void RegisterView(Noesis.View view, UnityEngine.Rendering.CommandBuffer commands)
    {
        commands.IssuePluginEventAndData(_renderRegisterCallback, 0, view.CPtr.Handle);
    }

    /// <summary>
    /// Sends offscreen render commands to native code
    /// </summary>
    public static void RenderOffscreen(Noesis.View view, UnityEngine.Rendering.CommandBuffer commands)
    {
        // This a way to force Unity to close the current MTL command encoder
        // We need to activate a new encoder in the current command buffer for our Offscreen phase
        if (UnityEngine.SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Metal)
        {
            UnityEngine.RenderTexture surface = UnityEngine.RenderTexture.GetTemporary(1,1);
            commands.SetRenderTarget(surface, LoadAction.DontCare, StoreAction.DontCare, LoadAction.DontCare, StoreAction.DontCare);
            commands.ClearRenderTarget(false, false, UnityEngine.Color.clear);
            UnityEngine.RenderTexture.ReleaseTemporary(surface);
        }

#if UNITY_EDITOR
        // When a texture is modified and reimported its native pointer changes, so we need to
        // send the new texture native pointer to C++ to update texture provider cache
        NoesisTextureProvider.instance.UpdateTextures();
#endif

        commands.IssuePluginEventAndData(_renderOffscreenCallback, (int)EventId.RenderOffscreen, view.CPtr.Handle);
    }

    /// <summary>
    /// Sends render commands to native code
    /// </summary>
    public static void RenderOnscreen(Noesis.View view, bool flipY, UnityEngine.Rendering.CommandBuffer commands)
    {
        // This is a workaround for a bug in Unity. When rendering nothing Unity sends us an empty MTLRenderCommandEncoder
        if (UnityEngine.SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Metal)
        {
            if (_dummyMesh == null)
            {
                _dummyMesh  = new UnityEngine.Mesh();
                _dummyMesh.vertices = new UnityEngine.Vector3[3];
                _dummyMesh.vertices[0] = new UnityEngine.Vector3(0, 0, 0);
                _dummyMesh.vertices[1] = new UnityEngine.Vector3(0, 0, 0);
                _dummyMesh.vertices[2] = new UnityEngine.Vector3(0, 0, 0);
                _dummyMesh.triangles = new int[3] { 0, 2, 1 };
            }

            if (_dummyMaterial == null)
            {
                _dummyMaterial = new UnityEngine.Material(UnityEngine.Shader.Find("UI/Default"));
            }

            commands.DrawMesh(_dummyMesh, new UnityEngine.Matrix4x4(), _dummyMaterial);
        }

        var eventId = flipY ? EventId.RenderOnscreenFlipY : EventId.RenderOnscreen;
        commands.IssuePluginEventAndData(_renderOnscreenCallback, (int)eventId, view.CPtr.Handle);
    }

    public static System.IntPtr CreatePixelShader(byte shader, byte[] bytes)
    {
        if (bytes != null)
        {
            if (_nextShaderId == 0)
            {
                // At domain reload _nextShaderId is reset, let's keep in sync with the render thread
                _commands.IssuePluginEventAndData(_renderClearShadersCallback, 0, System.IntPtr.Zero);
            }

            System.IntPtr ptr = Noesis_AllocateNative(bytes.Length);
            Marshal.Copy(bytes, 0, ptr, bytes.Length);
            _commands.IssuePluginEventAndData(_renderCreateShaderCallback, (int)((shader << 24) | bytes.Length), ptr);

            UnityEngine.Graphics.ExecuteCommandBuffer(_commands);
            _commands.Clear();

            return (System.IntPtr)(++_nextShaderId);
        }

        return System.IntPtr.Zero;
    }

    /// <summary>
    /// Unregister given renderer
    /// </summary>
    public static void UnregisterView(Noesis.View view, UnityEngine.Rendering.CommandBuffer commands)
    {
        commands.IssuePluginEventAndData(_renderUnregisterCallback, 0, view.CPtr.Handle);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetRenderSettings()
    {
        NoesisSettings settings = NoesisSettings.Get();

        bool linearRendering = false;

        switch (settings.linearRendering)
        {
            case NoesisSettings.LinearRendering._SamesAsUnity:
            {
                linearRendering = UnityEngine.QualitySettings.activeColorSpace == UnityEngine.ColorSpace.Linear;
                break;
            }
            case NoesisSettings.LinearRendering._Enabled:
            {
                linearRendering = true;
                break;
            }
            case NoesisSettings.LinearRendering._Disabled:
            {
                linearRendering = false;
                break;
            }
        }

        int sampleCount = 1;

        switch (settings.offscreenSampleCount)
        {
            case NoesisSettings.OffscreenSampleCount._SameAsUnity:
            {
                sampleCount = UnityEngine.QualitySettings.antiAliasing;
                break;
            }
            case NoesisSettings.OffscreenSampleCount._1x:
            {
                sampleCount = 1;
                break;
            }
            case NoesisSettings.OffscreenSampleCount._2x:
            {
                sampleCount = 2;
                break;
            }
            case NoesisSettings.OffscreenSampleCount._4x:
            {
                sampleCount = 4;
                break;
            }
            case NoesisSettings.OffscreenSampleCount._8x:
            {
                sampleCount = 8;
                break;
            }
        }

        uint offscreenDefaultNumSurfaces = settings.offscreenInitSurfaces;
        uint offscreenMaxNumSurfaces = settings.offscreenMaxSurfaces;

        int glyphCacheTextureWidth = 1024;
        int glyphCacheTextureHeight = 1024;

        switch (settings.glyphTextureSize)
        {
            case NoesisSettings.TextureSize._256x256:
            {
                glyphCacheTextureWidth = 256;
                glyphCacheTextureHeight = 256;
                break;
            }
            case NoesisSettings.TextureSize._512x512:
            {
                glyphCacheTextureWidth = 512;
                glyphCacheTextureHeight = 512;
                break;
            }
            case NoesisSettings.TextureSize._1024x1024:
            {
                glyphCacheTextureWidth = 1024;
                glyphCacheTextureHeight = 1024;
                break;
            }
            case NoesisSettings.TextureSize._2048x2048:
            {
                glyphCacheTextureWidth = 2048;
                glyphCacheTextureHeight = 2048;
                break;
            }
            case NoesisSettings.TextureSize._4096x4096:
            {
                glyphCacheTextureWidth = 4096;
                glyphCacheTextureHeight = 4096;
                break;
            }
        }

        Noesis_RendererSettings(linearRendering, sampleCount, offscreenDefaultNumSurfaces,
            offscreenMaxNumSurfaces, glyphCacheTextureWidth, glyphCacheTextureHeight);
    }

    #region Private
    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_GetRenderRegisterCallback();

    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_GetRenderOffscreenCallback();

    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_GetRenderOnscreenCallback();

    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_AllocateNative(int size);

    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_GetRenderClearShadersCallback();

    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_GetRenderCreateShaderCallback();

    [DllImport(Noesis.Library.Name)]
    private static extern System.IntPtr Noesis_GetRenderUnregisterCallback();

    [DllImport(Noesis.Library.Name)]
    private static extern void Noesis_RendererSettings(bool linearSpaceRendering, int offscreenSampleCount,
        uint offscreenDefaultNumSurfaces, uint offscreenMaxNumSurfaces, int glyphCacheTextureWidth, int glyphCacheTextureHeight);

    // Keep this in sync with UnityDevice in C++
    private enum EventId
    {
        RenderOffscreen = 0x6446,
        RenderOnscreen = 0x6447,
        RenderOnscreenFlipY = 0x6448
    }

    private static uint _nextShaderId;
    private static UnityEngine.Rendering.CommandBuffer _commands = new UnityEngine.Rendering.CommandBuffer();
    private static System.IntPtr _renderRegisterCallback = Noesis_GetRenderRegisterCallback();
    private static System.IntPtr _renderOffscreenCallback = Noesis_GetRenderOffscreenCallback();
    private static System.IntPtr _renderOnscreenCallback = Noesis_GetRenderOnscreenCallback();
    private static System.IntPtr _renderClearShadersCallback = Noesis_GetRenderClearShadersCallback();
    private static System.IntPtr _renderCreateShaderCallback = Noesis_GetRenderCreateShaderCallback();
    private static System.IntPtr _renderUnregisterCallback = Noesis_GetRenderUnregisterCallback();
    private static UnityEngine.Mesh _dummyMesh;
    private static UnityEngine.Material _dummyMaterial;
    #endregion
}