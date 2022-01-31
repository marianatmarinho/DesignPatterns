using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleBridge.Platforms
{
    interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
