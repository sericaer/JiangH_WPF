using System;
using JiangH.Kernel;
using System.ComponentModel;
using ReactiveMarbles.PropertyChanged;

namespace Mods.Native
{
    public class SceneMainView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged { add { } remove { } }

        public IPerson player { get; set; }

        public SceneMainView()
        {
            DataBase.inst.WhenChanged(x => x.player).Subscribe(p => this.player = p);
        }
    }

    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged { add { } remove { } }

        public string name { get; set; }

    }
}
