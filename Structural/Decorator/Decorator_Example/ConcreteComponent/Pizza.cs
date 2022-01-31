using Decorator_Example.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Example.ConcreteComponent
{
    class Pizza : IPizza
    {
        public string Opcionais()
        {
            var pizza = "Pizza padrão ou normal";
            return pizza;
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}
