using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    public interface ICalculadora
    {
        ICareTaker BackupUltimoCalculo();
        void RestaurarUltimoCalculo(ICareTaker memento);
        int GetCalculoResultado();
        void SetPrimeiroNumero(int num1);
        void SetSegundoNumero(int num2);
    }
}
