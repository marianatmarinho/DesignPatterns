using System;

namespace Mediator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

            User mariana = new ConcreteUser(facebookMediator, "Mariana");
            User alexandre = new ConcreteUser(facebookMediator, "Alexandre");
            User bob = new ConcreteUser(facebookMediator, "Bob");
            User sardinha = new ConcreteUser(facebookMediator, "Sardinha");

            facebookMediator.RegisterUser(mariana);
            facebookMediator.RegisterUser(alexandre);
            facebookMediator.RegisterUser(bob);
            facebookMediator.RegisterUser(sardinha);

            mariana.Send("O almoço está pronto");
            alexandre.Send("Vamos crianças!");
            mariana.Send("Lavem as mãos!");

            Console.Read();
        }
    }
}
