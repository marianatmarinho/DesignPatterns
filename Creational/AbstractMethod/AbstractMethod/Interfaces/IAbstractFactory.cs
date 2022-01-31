using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
