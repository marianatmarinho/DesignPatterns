using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Example
{
    interface IStore
    {
        void Visit(IVisitor visitor);
    }
}
