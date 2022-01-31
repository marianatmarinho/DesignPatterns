using ExampleComposite.Composite;
using ExampleComposite.Leaf;
using System;

namespace ExampleComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company{ Name = "Software Inc."};

            Company ITDepartment = new Company { Name = "TI" };
            ITDepartment.Add(new Employee { Id = 1001, Name = "Maria", Hours = 10 });
            ITDepartment.Add(new Employee { Id = 1002, Name = "João", Hours = 6 });
            ITDepartment.Add(new Employee { Id = 1003, Name = "´Guilherme", Hours = 12 });

            Company financeDepartment = new Company { Name = "Financeiro" };
            financeDepartment.Add(new Employee { Id = 1001, Name = "Paulo", Hours = 2 });
            financeDepartment.Add(new Employee { Id = 1002, Name = "Sthefani", Hours = 8 });

            company.Add(ITDepartment);
            company.Add(financeDepartment);
            company.GetWorkedHour();

            Console.ReadKey();
        }
    }
}
