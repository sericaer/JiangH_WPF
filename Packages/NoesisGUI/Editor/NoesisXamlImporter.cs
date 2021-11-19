//#define DEBUG_IMPORTER

using UnityEditor;
using UnityEngine;
using UnityEditor.AssetImporters;
using UnityEngine.Video;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

[ScriptedImporter(1, "xaml")]
class NoesisXamlImporter : ScriptedImporter
{
    static string[] GatherDependenciesFromSourceFile(string path)
    {
        Noesis.GUI.Init();

        List<string> deps = new List<string>();

        try
        {
            using (FileStream file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Noesis.GUI.GetXamlDependencies(file, path, (uri_, type) =>
                {
                    string uri = Noesis.UriHelper.GetPath(uri_);

                    if (type == Noesis.XamlDependencyType.Filename)
                    {
                        if (File.Exists(uri))
                        {
                            deps.Add(uri);
                        }
                    }
                    else if (type == Noesis.XamlDependencyType.Font)
                    {
                        foreach (var font in FindFonts(uri))
                        {
                            deps.Add(font);
                        }
                    }
                    else if (type == Noesis.XamlDependencyType.UserControl)
                    {
                        string xaml = FindUserControl(uri);
                        if (!String.IsNullOrEmpty(xaml) && xaml != path)
                        {
                            deps.Add(xaml);
                        }

                        string shader = FindShader(uri);
                        if (!String.IsNullOrEmpty(shader))
                        {
                            deps.Add(shader);
                        }
                    }
                });
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }

        return deps.ToArray();
    }

    private static string FindUserControl(string name)
    {
        return Directory.GetFiles(Application.dataPath, name + ".xaml", SearchOption.AllDirectories)
                .Select(path => path.Replace(Application.dataPath, "Assets"))
                .Select(path => path.Replace("\\", "/"))
                .FirstOrDefault();
    }

    private static string FindShader(string name)
    {
        if (name.EndsWith("Effect") || name.EndsWith("Brush"))
        {
            string shader = name.Replace("Effect", ".noesiseffect").Replace("Brush", ".noesisbrush");

            return Directory.GetFiles(Application.dataPath, shader, SearchOption.AllDirectories)
                    .Select(path => path.Replace(Application.dataPath, "Assets"))
                    .Select(path => path.Replace("\\", "/"))
                    .FirstOrDefault();
        }

        return null;
    }

    private static IEnumerable<string> FindFonts(string uri)
    {
        int index = uri.IndexOf('#');
        if (index != -1)
        {
            string folder = uri.Substring(0, index);
            if (Directory.Exists(folder))
            {
                string family = uri.Substring(index + 1);
                var files = Directory.GetFiles(folder).Where(s => IsFont(s));

                foreach (var font in files)
                {
                    using (FileStream file = File.Open(font, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        if (NoesisUnity.HasFamily(file, family))
                        {
                            yield return font;
                        }
                    }
                }
            }
        }
    }

    private static void AddFont(string uri, ref List<NoesisFont> fonts)
    {
        if (!String.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(uri)))
        {
            NoesisFont font = AssetDatabase.LoadAssetAtPath<NoesisFont>(uri);

            if (font != null)
            {
                fonts.Add(font);
            }
        }
    }

    private static void AddTexture(string uri, ref List<Texture> textures)
    {
        if (!String.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(uri)))
        {
            Texture texture = AssetDatabase.LoadAssetAtPath<Texture>(uri);

            if (texture != null)
            {
                textures.Add(texture);
            }
        }
    }

    private static void AddAudio(string uri, ref List<AudioClip> audios)
    {
        if (!String.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(uri)))
        {
            AudioClip audio = AssetDatabase.LoadAssetAtPath<AudioClip>(uri);

            if (audio != null)
            {
                audios.Add(audio);
            }
        }
    }

    private static void AddVideo(string uri, ref List<VideoClip> videos)
    {
        if (!String.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(uri)))
        {
            VideoClip video = AssetDatabase.LoadAssetAtPath<VideoClip>(uri);

            if (video != null)
            {
                videos.Add(video);
            }
        }
    }

    private static void AddXaml(string uri, ref List<NoesisXaml> xamls)
    {
        if (!String.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(uri)))
        {
            NoesisXaml xaml = AssetDatabase.LoadAssetAtPath<NoesisXaml>(uri);

            if (xaml != null)
            {
                xamls.Add(xaml);
            }
        }
    }

    private static void AddShader(string uri, ref List<NoesisShader> shaders)
    {
        if (!String.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(uri)))
        {
            NoesisShader shader = AssetDatabase.LoadAssetAtPath<NoesisShader>(uri);

            if (shader != null)
            {
                shaders.Add(shader);
            }
        }
    }

    private static string ScanDependencies(AssetImportContext ctx, out List<NoesisFont> fonts_,
        out List<Texture> textures_, out List<AudioClip> audios_, out List<VideoClip> videos_,
        out List<NoesisXaml> xamls_, out List<NoesisShader> shaders_)
    {
        List<NoesisFont> fonts = new List<NoesisFont>();
        List<Texture> textures = new List<Texture>();
        List<AudioClip> audios = new List<AudioClip>();
        List<VideoClip> videos = new List<VideoClip>();
        List<NoesisXaml> xamls = new List<NoesisXaml>();
        List<NoesisShader> shaders = new List<NoesisShader>();

        string filename = ctx.assetPath;
        string root = "";

        try
        {
            using (FileStream file = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Noesis.GUI.GetXamlDependencies(file, filename, (uri_, type) =>
                {
                    // Although dependencies were already added in GatherDependenciesFromSourceFile,
                    // here we are adding them again because GatherDependenciesFromSourceFile
                    // complains if we add invalid dependencies

                    try
                    {
                        string uri = Noesis.UriHelper.GetPath(uri_);

                        if (type == Noesis.XamlDependencyType.Filename)
                        {
                            ctx.DependsOnArtifact(uri);

                            AddXaml(uri, ref xamls);
                            AddTexture(uri, ref textures);
                            AddAudio(uri, ref audios);
                            AddVideo(uri, ref videos);
                        }
                        else if (type == Noesis.XamlDependencyType.Font)
                        {
                            foreach (var font in FindFonts(uri))
                            {
                                ctx.DependsOnArtifact(font);
                                AddFont(font, ref fonts);
                            }
                        }
                        else if (type == Noesis.XamlDependencyType.UserControl)
                        {
                            string xaml = FindUserControl(uri);
                            if (!String.IsNullOrEmpty(xaml) && xaml != filename)
                            {
                                ctx.DependsOnArtifact(xaml);
                                AddXaml(xaml, ref xamls);
                            }

                            string shader = FindShader(uri);
                            if (!String.IsNullOrEmpty(shader))
                            {
                                ctx.DependsOnArtifact(shader);
                                AddShader(shader, ref shaders);
                            }
                        }
                        else if (type == Noesis.XamlDependencyType.Root)
                        {
                            root = uri;
                        }
                    }
                    catch (Exception e)
                    {
                         Debug.LogException(e);
                    }
                });
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }

        fonts_ = fonts;
        textures_ = textures;
        audios_ = audios;
        videos_ = videos;
        xamls_ = xamls;
        shaders_ = shaders;

        return root;
    }

    public override void OnImportAsset(AssetImportContext ctx)
    {
        Noesis.GUI.Init();

        #if DEBUG_IMPORTER
            Debug.Log($"=> Import {ctx.assetPath}");
        #endif

        NoesisXaml xaml = (NoesisXaml)ScriptableObject.CreateInstance<NoesisXaml>();
        xaml.uri = ctx.assetPath;
        xaml.content = System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(ctx.assetPath));

        // Add dependencies
        List<NoesisFont> fonts;
        List<Texture> textures;
        List<AudioClip> audios;
        List<VideoClip> videos;
        List<NoesisXaml> xamls;
        List<NoesisShader> shaders;

        string root = ScanDependencies(ctx, out fonts, out textures, out audios, out videos, out xamls, out shaders);

        xaml.UnregisterDependencies();
        xaml.xamls = xamls.Select(t => new NoesisXaml.Xaml { uri = AssetDatabase.GetAssetPath(t), xaml = t} ).ToArray();
        xaml.textures = textures.Select(t => new NoesisXaml.Texture { uri = AssetDatabase.GetAssetPath(t), texture = t} ).ToArray();
        xaml.audios = audios.Select(t => new NoesisXaml.Audio { uri = AssetDatabase.GetAssetPath(t), audio = t} ).ToArray();
        xaml.videos = videos.Select(t => new NoesisXaml.Video { uri = AssetDatabase.GetAssetPath(t), video = t }).ToArray();
        xaml.fonts = fonts.Select(t => new NoesisXaml.Font { uri = AssetDatabase.GetAssetPath(t), font = t }).ToArray();
        xaml.shaders = shaders.Select(t => new NoesisXaml.Shader { uri = Path.GetFileName(AssetDatabase.GetAssetPath(t)), shader = t} ).ToArray();
        xaml.RegisterDependencies();

        if (ctx.assetPath.StartsWith("Assets/") && root != "ResourceDictionary")
        {
            ctx.DependsOnCustomDependency("Noesis_ApplicationResources");
        }

        ctx.AddObjectToAsset("XAML", xaml);
        ctx.SetMainObject(xaml);
    }

    private static bool HasExtension(string filename, string extension)
    {
        return filename.EndsWith(extension, StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsFont(string filename)
    {
        return HasExtension(filename, ".ttf") || HasExtension(filename, ".otf") || HasExtension(filename, ".ttc");
    }
}
