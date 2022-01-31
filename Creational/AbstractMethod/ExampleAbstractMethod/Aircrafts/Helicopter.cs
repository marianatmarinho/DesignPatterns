using ExampleAbstractMethod.Aircrafts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractMethod.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento, vento sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok. Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem do helicoptero");
        }
    }
}
