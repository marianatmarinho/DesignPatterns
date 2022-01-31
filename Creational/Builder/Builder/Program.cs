using Builder.Classes;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Stardard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Stardard full featured product:");
            director.BuildFullFeatureProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom Product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.ReadKey();
        }
    }
}
