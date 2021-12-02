#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

namespace JiangH.UI
{

    [TemplatePart(Name = "CloseButton", Type = typeof(Button))]
    public class CloseAblePanel : ContentControl
    {
        public const string defaultImageName = "PANEL_IMAGE_DEFAULT.jpg";

        static CloseAblePanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseAblePanel), new FrameworkPropertyMetadata(typeof(CloseAblePanel)));
        }

        public Brush CheckedForeground
        {
            get
            {
                var imageFileName = Name == null || Name == "" ? defaultImageName : $"PANEL_IMAGE_{Name}.jpg";
                return ModImageBrush.Create(imageFileName, defaultImageName);
            }
        }

        public override void OnApplyTemplate()
        {
            ApplyTemplate();

            var partControlsLayer = GetTemplateChild("CloseButton") as Button;
            partControlsLayer.Click += (sender, e) =>
            {
                var parent = this.Parent as Panel;
                parent.Children.Remove(this);
            };
        }
    }
}
