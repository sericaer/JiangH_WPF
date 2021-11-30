#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
#endif
using System;
using System.IO;
using System.Reflection;

namespace JiangH
{
    /// <summary>
    /// Interaction logic for JiangHMainView.xaml
    /// </summary>
    public partial class JiangHMainView : UserControl
    {
        public JiangHMainView()
        {
            InitializeComponent();

#if NOESIS
            var filePath = UnityEngine.Application.streamingAssetsPath;
#else
            var filePath = "../../../Assets/StreamingAssets";
#endif


            var str = File.ReadAllText(filePath + "/mods/native/SceneMain.xaml");

            var ass = Assembly.Load(File.ReadAllBytes(filePath + "/mods/native/Assembly.dll"));

            var userControl = XamlReader.Parse(str) as UserControl;

            var uiElement = userControl.Content as UIElement;
            userControl.Content = null;

            this.rootCanvas.Children.Add(uiElement);
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);

            var dict = (ResourceDictionary)GUI.LoadXaml("Assets/Resources/GUI/Generic.xaml");

            ResourceDictionary app = Noesis.GUI.GetApplicationResources();
            app.MergedDictionaries.Add(dict);

            rootCanvas = (Canvas)FindName("rootCanvas");
        }

        private Canvas rootCanvas;
#endif


    }
}