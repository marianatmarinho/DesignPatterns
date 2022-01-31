using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Example
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cliente(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }
    }
}
