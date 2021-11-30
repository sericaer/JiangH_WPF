#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace JiangHKernel.UI
{

    [TemplatePart(Name = "CloseButton", Type = typeof(Button))]
    public class CloseAblePanel : ContentControl
    {
        static CloseAblePanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseAblePanel), new FrameworkPropertyMetadata(typeof(CloseAblePanel)));
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
