using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
