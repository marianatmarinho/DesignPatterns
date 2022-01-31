using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSigleThread
{
    public sealed class Singleton
    {
        public String DataItem { get; set; }
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance is null)
                _instance = new Singleton();

            return _instance;
        }
    }
}
