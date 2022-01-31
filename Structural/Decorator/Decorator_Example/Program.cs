using Decorator_Example.Component;
using Decorator_Example.ConcreteComponent;
using Decorator_Example.ConcreteDecorator;
using System;

namespace Decorator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.Opcionais());
            Console.WriteLine($"Preço R$ {pizza.Preco()}\n");
            Console.WriteLine("Tecle algo para aplicar o padrão Decorator: ");
            Console.ReadKey();

            Console.WriteLine("---------------- Aplicando Decorator ----------------");

            IPizza pizzaDecorator = new Pizza();
            IPizza massaEspecial = new MassaEspecialDecorator(pizzaDecorator);
            IPizza bacon = new BaconDecorator(massaEspecial);
            IPizza borda = new BordaRecheadaDecorator(bacon);

            Console.WriteLine(borda.Opcionais());
            Console.WriteLine($"Preco Total: R$ {borda.Preco()}\n");
            Console.ReadKey();
        }
    }
}
