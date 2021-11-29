#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
#endif
using System;
using System.IO;
using System.ComponentModel;
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

            var path = "D:\\git\\JiangH\\Assets\\StreamingAssets\\mods\\native\\Assembly.dll";
            var str = File.ReadAllText(filePath + "/mods/native/SceneMain.xaml");

            var ass = Assembly.LoadFile(path);

            AppDomain.CurrentDomain.Load(ass.GetName());
            var Assemblies = AppDomain.CurrentDomain.GetAssemblies();

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

namespace TT
{
    public class Test : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int a { get; set; }
        public Inner inner { get; set; }

        public Test()
        {
            a = 2000;
        }
    }

    public class Inner : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int b { get; set; }

        public Inner()
        {
            b = 3000;
        }
    }
}