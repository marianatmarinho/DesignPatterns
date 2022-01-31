using ExampleAbstractMethod.Aircrafts.Interfaces;
using ExampleAbstractMethod.Enums;
using ExampleAbstractMethod.Factories.Interfaces;
using ExampleAbstractMethod.LandVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractMethod.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory, AircraftType aircraftType, LandVehicleType landVehicleType)
        {
            aircraft = factory.CreateTransportAircraft(aircraftType);
            vehicle = factory.CreateTransportVehicle(landVehicleType);
        }

        public void StartRoute()
        {
            Console.WriteLine($"Entrega Terrestre:");
            vehicle.StartRoute();
            Console.WriteLine();
            Console.WriteLine($"Entrega Aérea:");
            aircraft.StartRoute();
        }
    }
}
