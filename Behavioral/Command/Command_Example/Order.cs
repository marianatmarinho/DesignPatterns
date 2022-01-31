using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Example
{
    public class Order : Command
    {
        public Chef Chef { get; set; }
        public string Action { get; set; }

        public Order(Chef chef, string action)
        {
            Chef = chef;
            Action = action;
        }
        public override void Execute()
        {
            if(Action.Equals("Prato"))
            {
                Chef.PreparingDish();
            }
            else
            {
                Chef.PreparingDessert();
            }
        }
    }
}
