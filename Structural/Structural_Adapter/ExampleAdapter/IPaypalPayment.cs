using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapter
{
    interface IPaypalPayment
    {
        Token AuthToken();
        void PaypalPayment();
        void PaypalReceive();
    }
}
