using ExampleAbstractMethod.App;
using ExampleAbstractMethod.Enums;
using ExampleAbstractMethod.Factories;
using ExampleAbstractMethod.Factories.Interfaces;
using System;

namespace ExampleAbstractMethod
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory transportFactory;
            string company = "Uber";
            AircraftType aircraftType = 0;
            LandVehicleType landVehicleType = 0;

            Console.WriteLine($"Empresa: {company}");
            Console.WriteLine();

            if (company == "Uber")
            { 
                transportFactory = new UberTransport();
                aircraftType = AircraftType.Helicopter;
                landVehicleType = LandVehicleType.Car;
            }
            else if (company == "NineNine")
            {
                transportFactory = new NineNineTransport();
                aircraftType = AircraftType.Airplane;
                landVehicleType = LandVehicleType.Motorcycle;
            }
            else
            {
                transportFactory = new LimeTransport();
                aircraftType = AircraftType.Drone;
                landVehicleType = LandVehicleType.EletricScooter;
            }

            app = new Application(transportFactory, aircraftType, landVehicleType);

            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
