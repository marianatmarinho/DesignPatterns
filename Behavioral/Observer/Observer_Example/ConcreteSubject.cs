using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string Produto { get; set; }
        private int Preco { get; set; }
        public string Disponibilidade { get; set; }

        public ConcreteSubject(string produto, int preco, string status)
        {
            Produto = produto;
            Preco = preco;
            Disponibilidade = status;
        }

        public string GetDisponibilidade()
        {
            return Disponibilidade;
        }

        public void SetDisponibilidade(string status)
        {
            Disponibilidade = status;
            Console.WriteLine($"A disponibilidade foi alterada para {status}");
            NotificarObservers();
        }

        public void NotificarObservers()
        {
            Console.WriteLine($"O produto {Produto} no valor de R${Preco} está disponivel!");
            foreach(IObserver observer in observers)
            {
                observer.Atualiza(Disponibilidade);
            }
        }

        public void RegistarObserver(IObserver observer)
        {
            Console.WriteLine($"Observer adicionado: {((ConcreteObserver)observer).Usuario}");
            observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
