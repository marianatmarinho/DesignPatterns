using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapter
{
    interface IMercadoPagoPayment
    {
        Token AuthMPToken();
        void SendMPPayment();
        void ReceiveMPPayment();
    }
}
