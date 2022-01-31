using Decorator_Example.Component;
using Decorator_Example.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Example.ConcreteDecorator
{
    class MassaEspecialDecorator : PizzaDecorator
    {
        public MassaEspecialDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\n com massa especial";
            return pizza;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 12.00M;
            return preco;
        }
    }
}
