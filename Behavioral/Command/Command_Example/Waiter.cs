using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Example
{
    public class Waiter 
    {
        private Order _order;
        public Waiter(Order order)
        {
            _order = order;
        }

        public void Invoke()
        {
            _order.Execute();
        }
    }
}
