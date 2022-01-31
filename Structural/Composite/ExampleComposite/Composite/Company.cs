using ExampleComposite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleComposite.Composite
{
    class Company : WorkedHour
    {
        protected List<WorkedHour> departments = new List<WorkedHour>();
        public override void Add(WorkedHour component)
        {
            departments.Add(component);
        }
        public override void Remove(WorkedHour component)
        {
            departments.Remove(component);
        }
        public override int GetWorkedHour()
        {
            var workedHoursDepartment = 0;
            foreach(var department in departments)
            {
                workedHoursDepartment += department.GetWorkedHour();
            }
            Console.WriteLine($"{Name} registrou um total de {workedHoursDepartment} horas.");
            return workedHoursDepartment;
        }
    }
}
