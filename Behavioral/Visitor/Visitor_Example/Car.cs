using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Example
{
    public class Car : IStore
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accepet(this);
        }
    }
}
