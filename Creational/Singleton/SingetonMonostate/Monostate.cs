using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMonostate
{
    public sealed class Monostate
    {
        private static string dataItem;
        public string DataItem
        { 
            get { return dataItem; }
            set { dataItem = value; } 
        }
        public Monostate() { }
    }
}
