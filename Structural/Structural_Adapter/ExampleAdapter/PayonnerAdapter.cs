using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapter
{
    class PayonnerAdapter : IPaypalPayment
    {
        private Payonner _payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            _payonner = payonner;
            Console.WriteLine("Realizando adaptação de Payonner para Paypal.");
        }
        public Token AuthToken()
        {
            return _payonner.AuthToken();
        }

        public void PaypalPayment()
        {
            _payonner.SendPayment();
        }

        public void PaypalReceive()
        {
            _payonner.ReceivePayment();
        }
    }
}
