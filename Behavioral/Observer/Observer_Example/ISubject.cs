using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public interface ISubject
    {
        void RegistarObserver(IObserver observer);
        void RemoverObserver(IObserver observer);
        void NotificarObservers();
    }
}
