using ExampleAbstractMethod.Aircrafts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractMethod.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando o vento, descolagem ok.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegando a encomenda por drone.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
