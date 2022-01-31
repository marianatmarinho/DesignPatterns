using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMultiThread
{
    public sealed class Singleton
    {
        private static int contador = 0;
        private static Singleton _instance;
        private static object lockObject = new object();
        private Singleton() {
            contador++;
            Console.WriteLine("Instancia " + contador);
        }

        public static Singleton GetInstance()
        {
            lock (lockObject)
            {
                if (_instance is null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }
}
