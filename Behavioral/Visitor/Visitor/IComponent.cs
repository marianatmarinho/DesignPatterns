using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Conceptual
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
