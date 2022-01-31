using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Example
{
    public interface IVisitor
    {
        void Accepet(Car carro);
    }
}
