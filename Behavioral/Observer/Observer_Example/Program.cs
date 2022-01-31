using System;

namespace Observer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject Iphone = new ConcreteSubject("IPhone", 5000, "SEM ESTOQUE");
            Console.WriteLine($"Iphone: {Iphone.GetDisponibilidade()}");

            Console.WriteLine("Usuários inscritos para receber notificações. ");
            ConcreteObserver mariana = new ConcreteObserver("Mariana", Iphone);
            ConcreteObserver alexandre = new ConcreteObserver("Alexandre", Iphone);
            Console.WriteLine();

            Console.WriteLine("Pressione uma tecla para tornar o produto disponível: ");
            Console.ReadKey();

            Iphone.SetDisponibilidade("DISPONIVEL");

            Console.ReadKey();
        }
    }
}
