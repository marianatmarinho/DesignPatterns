using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapter
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        private MercadoPago _mercadoPago;
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de MercadoPago para Paypal.");
        }
        public Token AuthToken()
        {
            return _mercadoPago.AuthMPToken();
        }

        public void PaypalPayment()
        {
            _mercadoPago.ReceiveMPPayment();
        }

        public void PaypalReceive()
        {
            _mercadoPago.ReceiveMPPayment();
        }
    }
}
