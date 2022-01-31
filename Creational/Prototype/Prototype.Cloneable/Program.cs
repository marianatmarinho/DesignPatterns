using System;

namespace Prototype.ShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.Name = "Soldier 1";
            soldier.Weapon = "Gum 64";
            soldier.Accessory = new Accessory { Name = "Night Vision" };

            //clone 1
            Soldier soldier_clone1 = (Soldier)soldier.Clone();
            soldier_clone1.Name = "Soldier Clone 1";
            soldier_clone1.Weapon = "Gum 123";
            soldier_clone1.Accessory.Name = "Invisible";

            //clone 2
            Soldier soldier_clone2 = (Soldier)soldier.Clone();
            soldier_clone2.Name = "Soldier Clone 2";
            soldier_clone2.Weapon = "Gum Secret";
            soldier_clone2.Accessory.Name = "Fire";

            Console.WriteLine("Original object");
            Console.WriteLine($"{soldier.Name} - {soldier.Weapon} - {soldier.Accessory.Name}");

            Console.WriteLine("Clone 1 object");
            Console.WriteLine($"{soldier_clone1.Name} - {soldier_clone1.Weapon} - {soldier_clone1.Accessory.Name}");

            Console.WriteLine("Clone 1 object");
            Console.WriteLine($"{soldier_clone2.Name} - {soldier_clone2.Weapon} - {soldier_clone2.Accessory.Name}");
        }
    }
}
