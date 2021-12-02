#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
using System.IO;
using UnityEngine;
#else
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
#endif

namespace JiangH.UI
{
    static class ModImageBrush
    {
        internal static Brush Create(string imageFileName, string defaultImageName)
        {
            var path = $"D:\\git\\JiangH\\Assets\\StreamingAssets\\mods\\native\\images\\{imageFileName}";
            if (!File.Exists(path))
            {
                path = $"D:\\git\\JiangH\\Assets\\StreamingAssets\\mods\\native\\images\\{defaultImageName}";
            }
#if NOESIS
            var fileData = File.ReadAllBytes(path);
            var tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
            return new ImageBrush(new TextureSource(tex));
#else
            var image = new BitmapImage(new Uri(path));
            return new ImageBrush(image);
#endif
        }
    }
}