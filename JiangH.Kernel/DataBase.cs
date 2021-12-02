using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace JiangH.Kernel
{
    public class DataBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged { add { } remove { } }

        public static DataBase inst;

        public IPerson player { get; set; }

        public ObservableCollection<IPerson> persons;
    }

    public interface IPerson : INotifyPropertyChanged
    {
        string fullName { get; set; }
    }

    public class Person : IPerson
    {
        public event PropertyChangedEventHandler PropertyChanged { add { } remove { } }

        public string fullName { get; set; }
    }
}
