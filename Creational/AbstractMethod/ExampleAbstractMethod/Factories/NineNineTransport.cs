using ExampleAbstractMethod.Aircrafts;
using ExampleAbstractMethod.Aircrafts.Interfaces;
using ExampleAbstractMethod.Enums;
using ExampleAbstractMethod.Factories.Interfaces;
using ExampleAbstractMethod.LandVehicles;
using ExampleAbstractMethod.LandVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractMethod.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft(AircraftType type)
        {
            if (type == AircraftType.Helicopter)
                return new Helicopter();
            else if (type == AircraftType.Drone)
                return new Drone();
            else
                return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle(LandVehicleType type)
        {
            if (type == LandVehicleType.Motorcycle)
                return new Motorcycle();
            else if (type == LandVehicleType.EletricScooter)
                return new EletricScooter();
            else
                return new Car();
        }
    }
}
