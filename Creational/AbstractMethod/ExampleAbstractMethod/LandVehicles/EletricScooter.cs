using ExampleAbstractMethod.LandVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractMethod.LandVehicles
{
    class EletricScooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando a encomenda de patinete!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
