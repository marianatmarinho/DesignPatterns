using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    public class Calculadora : ICalculadora
    {
        private int primeiroNumero;
        private int segundoNumero;
        public ICareTaker BackupUltimoCalculo()
        {
            //cria um memento usado para restaurar dois numeros
            return new Memento(primeiroNumero, segundoNumero);
        }

        public int GetCalculoResultado()
        {
            return primeiroNumero + segundoNumero;
        }

        public void RestaurarUltimoCalculo(ICareTaker memento)
        {
            primeiroNumero = ((IMemento)memento).GetPrimeiroNumero();
            segundoNumero = ((IMemento)memento).GetSegundoNumero();
        }

        public void SetPrimeiroNumero(int num1)
        {
            primeiroNumero = num1;
        }

        public void SetSegundoNumero(int num2)
        {
            segundoNumero = num2;
        }
    }
}
