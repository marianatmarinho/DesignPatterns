using ExampleAbstractMethod.LandVehicles.Interfaces;
using System;

namespace ExampleAbstractMethod.LandVehicles
{
    class Motorcycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
