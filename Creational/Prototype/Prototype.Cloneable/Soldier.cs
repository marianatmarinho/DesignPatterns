using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ShallowCopy
{
    class Soldier : ICloneable
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public Accessory Accessory { get; set; }

        public Soldier() { }

        public Soldier(Soldier soldier)
        {
            this.Name = soldier.Name;
            this.Weapon = soldier.Weapon;
            this.Accessory = soldier.Accessory;
        }
        public object Clone()
        {
            return new Soldier(this);
        }
    }
}
