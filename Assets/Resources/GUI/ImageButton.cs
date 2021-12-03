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
    public class ImageButton : Button
    {
        public const string defaultImageName = "BUTTON_IMAGE_DEFAULT.jpg";

        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public Brush CheckedForeground
        {
            get
            {
                var modName = this.FindResource("modName") as string;

                var imageFileName = Name == null || Name == "" ? defaultImageName : $"BUTTON_IMAGE_{Name}.jpg";
                return ModImageBrush.Create(modName, imageFileName, defaultImageName);
            }
        }
    }
}
