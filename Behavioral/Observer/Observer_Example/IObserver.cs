using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public interface IObserver
    {
        void Atualiza(string disponibilidade);
    }
}
