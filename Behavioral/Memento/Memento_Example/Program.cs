using System;

namespace Memento_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calculadora = new Calculadora();

            //primeira soma
            calculadora.SetPrimeiroNumero(10);
            calculadora.SetSegundoNumero(100);

            Console.WriteLine($"Estado 1: {calculadora.GetCalculoResultado()}");

            //faz o backup
            ICareTaker memento = calculadora.BackupUltimoCalculo();

            //segunda som
            calculadora.SetPrimeiroNumero(17);
            calculadora.SetSegundoNumero(-100);

            Console.WriteLine($"Estado 2: {calculadora.GetCalculoResultado()}");

            Console.WriteLine("\nRestaurando o resultado da soma anterior: ");
            calculadora.RestaurarUltimoCalculo(memento);
            Console.WriteLine($"{calculadora.GetCalculoResultado()}");

            Console.ReadKey();
        }
    }
}
