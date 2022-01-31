using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.DeepCopy
{
    class Accessory
    {
        public string Name { get; set; }

        public object Clone()
        {
            return (Accessory)this.MemberwiseClone();
        }
    }
}
