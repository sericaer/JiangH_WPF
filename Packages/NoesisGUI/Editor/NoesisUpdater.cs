using UnityEngine;
using UnityEditor;
using System;
using System.Linq;
using System.IO;

[InitializeOnLoad]
public class NoesisUpdater
{
    static NoesisUpdater()
    {
        EditorApplication.update += CheckVersion;
    }

    private static void CheckVersion()
    {
        EditorApplication.update -= CheckVersion;

        if (!UnityEditorInternal.InternalEditorUtility.inBatchMode)
        {
            var package = UnityEditor.PackageManager.PackageInfo.FindForAssetPath("Packages/com.noesis.noesisgui");

            if (package == null)
            {
                Debug.LogError("Can't find package 'com.noesis.noesisgui'. Please, make sure you didn't unzip the plugin inside '/Assets'");
            }
            else
            {
                var settings = NoesisSettings.Get();
                string localVersion = settings.Version;
                string version = package.version;
    
                if (localVersion != version)
                {
                    settings.Version = version;

                    UpdateAssets();

                    if (version != "0.0.0")
                    {
                        GoogleAnalyticsHelper.LogEvent("Install", version, 0);
                    }

                    EditorApplication.update += ShowWelcomeWindow;
                    Debug.Log("NoesisGUI v" + version + " successfully installed");
                }
            }
        }
    }

    private static void ShowWelcomeWindow()
    {
        EditorApplication.update -= ShowWelcomeWindow;
        NoesisWelcome.Open();
    }

    private static void UpdateAssets()
    {
        var assets = AssetDatabase.FindAssets("")
            .Select(guid => AssetDatabase.GUIDToAssetPath(guid))
            .Where(s => s.StartsWith("Assets/") && (IsFont(s) || IsXaml(s)))
            .Distinct().ToArray();

        foreach (var asset in assets)
        {
            // Remove old 3.0 asset if there is any
            AssetDatabase.DeleteAsset(Path.ChangeExtension(asset, ".asset"));

            // Reimport asset to assign proper importer
            AssetDatabase.ImportAsset(asset);
        }
    }

    private static bool HasExtension(string filename, string extension)
    {
        return filename.EndsWith(extension, StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsXaml(string filename)
    {
        return HasExtension(filename, ".xaml");
    }

    private static bool IsFont(string filename)
    {
        return HasExtension(filename, ".ttf") || HasExtension(filename, ".otf") || HasExtension(filename, ".ttc");
    }
}
