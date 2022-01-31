using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Example
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name}: recebida =< {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name}: enviada =< {message}");
            mediator.SendMessage(message, this);
        }
    }
}
