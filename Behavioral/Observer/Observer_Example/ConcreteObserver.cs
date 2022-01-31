using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public class ConcreteObserver : IObserver
    {
        public string Usuario { get; set; }
        public ConcreteObserver(string nome, ISubject subject)
        {
            Usuario = nome;
            subject.RegistarObserver(this);
        }
        public void Atualiza(string disponibilidade)
        {
            Console.WriteLine($"Usuário {Usuario}: produto atualizado para a disponibilidade {disponibilidade}!");
        }
    }
}
