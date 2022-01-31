using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleComposite.Component
{
    public abstract class WorkedHour
    {
        public WorkedHour()
        {

        }

        public string Name { get; set; }
        public abstract int GetWorkedHour();

        public virtual void Add(WorkedHour component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(WorkedHour component)
        {
            throw new NotImplementedException();
        }
    }
}
