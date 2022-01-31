using ExampleBridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridge.Transmissions
{
    class Live : ITransmission
    {
        protected IPlatform _platform;
        public Live(IPlatform platform)
        {
            _platform = platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("*****ON AIR*****");
        }
    }
}
