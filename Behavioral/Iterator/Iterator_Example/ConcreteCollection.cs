using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Example
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listaClientes.Count; }
        }

        public void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public Cliente GetCliente(int posicao)
        {
            return listaClientes[posicao];
        }
    }
}
