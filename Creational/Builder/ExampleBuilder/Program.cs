using ExampleBuilder.Builders;
using ExampleBuilder.Directors;
using ExampleBuilder.Products;
using System;

namespace ExampleBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {sedan.VehicleType}");

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {truck.VehicleType}");

            director.ConstructSUV();
            Vehicle SUV = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {SUV.VehicleType}");
        }
    }
}
