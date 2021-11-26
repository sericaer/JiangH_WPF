#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
using System.IO;
using UnityEngine;
#else
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
#endif

namespace JiangH
{
    public class ImageButton : Button
    {
        public const string defaultImageName = "BUTTON_IMAGE_DEFAULT";

        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public Brush CheckedForeground
        {
            get
            {
                var imageFileName = Name == null || Name == "" ? defaultImageName : $"BUTTON_IMAGE_{Name}";

                return MakeImageBrush(imageFileName);

            }
        }

        private Brush MakeImageBrush(string imageFileName)
        {
#if NOESIS
            var fileData = File.ReadAllBytes($"D:\\git\\NoesisStudy\\Assets\\StreamingAssets\\{imageFileName}.jpg");
            var tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
            return new ImageBrush(new TextureSource(tex));
#else
            var image = new BitmapImage(new Uri($"D:\\git\\NoesisStudy\\Assets\\StreamingAssets\\{imageFileName}.jpg"));
            return new ImageBrush(image);
#endif
        }
    }
}
