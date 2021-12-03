using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiangH.Kernel
{
    public class ModManager
    {
        public static ModManager inst;

        public Mod native;
    }

    public class Mod
    {
        public Dictionary<string, string> xamlDict;
    }
}
