using ExampleComposite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleComposite.Leaf
{
    class Employee : WorkedHour
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        public override int GetWorkedHour()
        {
            Console.WriteLine($"O Funcionário {Id} - {Name} registrou {Hours} trabalhadas.");
            return Hours;
        }
    }
}
