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
using JiangH.Kernel;
using JiangH.UI;

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

//#if NOESIS
//            Global.modRootPath = UnityEngine.Application.streamingAssetsPath + "/mods";
//#else
//            Global.modRootPath = System.IO.Path.GetFullPath("../../../Assets/StreamingAssets/mods");
//#endif

            //ModManager.inst = new ModManager();

            //DataBase.inst = new DataBase();

            //var userControl = XamlReader.Parse(ModManager.inst.native.xamlDict["SceneMain"]) as UserControl;

            //var uiElement = userControl.Content as UIElement;
            //userControl.Content = null;

            //this.rootCanvas.Children.Add(uiElement);


            DataBase.inst = new DataBase();
            DataBase.inst.player = new Person();
            DataBase.inst.player.fullName = "fullName";

            var str = File.ReadAllText(Global.modRootPath + "/native/SceneMain.xaml");

            //var ass1 = Assembly.Load(File.ReadAllBytes(@"D:\git\JiangH\Assets\Managed\JiangH.Kernel.dll"));

            var ass = Assembly.Load(File.ReadAllBytes(Global.modRootPath + "/native/Assembly.dll"));

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