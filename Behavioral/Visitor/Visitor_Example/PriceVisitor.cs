using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Example
{
    public class PriceVisitor : IVisitor
    {
        private const int DISCOUNT_CAR = 12;
        public void Accepet(Car carro)
        {
            decimal carPriceWithDiscount = carro.Price - ((carro.Price / 100) * DISCOUNT_CAR);

            Console.WriteLine($"{carro.Model} {carro.Name}: {carPriceWithDiscount}");
        }
    }
}
