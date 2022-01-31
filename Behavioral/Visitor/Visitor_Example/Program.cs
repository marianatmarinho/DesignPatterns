using System;
using System.Collections.Generic;

namespace Visitor_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car() { Name = "A1", Price = 2000M, Model = "Mercedes" });
            cars.Add(new Car() { Name = "A2", Price = 5000M, Model = "Audi" });

            List<IStore> stores = new List<IStore>();

            Console.WriteLine("Normal Prices: ");
            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Name}:{car.Price}");
                stores.Add(car);
            }

            Console.WriteLine("Cars with discount: ");
            PriceVisitor priceVisitor = new PriceVisitor();
            foreach(var element in stores)
            {
                element.Visit(priceVisitor);
            }

            Console.ReadLine();
        }
    }
}
