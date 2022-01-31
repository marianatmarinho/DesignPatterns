using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.DeepCopy
{
    class Soldier
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
            Soldier soldier = (Soldier)this.MemberwiseClone();
            soldier.Accessory = (Accessory)this.Accessory.Clone();
            return soldier;
        }
    }
}
