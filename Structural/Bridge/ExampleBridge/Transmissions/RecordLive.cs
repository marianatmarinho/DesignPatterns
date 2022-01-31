using ExampleBridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridge.Transmissions
{
    class RecordLive : AdvancedLive
    {
        public RecordLive(IPlatform platform) : base(platform)
        {
            
        }
        public void Record()
        {
            Console.WriteLine("Gravando Live!");
        }
    }
}
