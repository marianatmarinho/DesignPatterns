using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Example
{
    public class Iterator : IAbstractIterator
    {
        private int current = 0;
        private int step = 1;

        private ConcreteCollection collection;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public Cliente First()
        {
            current = 0;
            return collection.GetCliente(current);
        }

        public Cliente Next()
        {
            current += step;
            if(!IsDone)
            {
                return collection.GetCliente(current);
            }
            else
            {
                return null;
            }
        }

        public bool IsDone
        {
            get { return current >= collection.Count;  }
        }
    }
}
