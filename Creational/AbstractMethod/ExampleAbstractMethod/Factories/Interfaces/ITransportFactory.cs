using ExampleAbstractMethod.Aircrafts.Interfaces;
using ExampleAbstractMethod.Enums;
using ExampleAbstractMethod.LandVehicles.Interfaces;

namespace ExampleAbstractMethod.Factories.Interfaces
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft(AircraftType type);

        ILandVehicle CreateTransportVehicle(LandVehicleType type);
    }
}
