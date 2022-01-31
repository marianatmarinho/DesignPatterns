using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAdapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthMPToken()
        {
            return new Token();
        }

        public void ReceiveMPPayment()
        {
            token = AuthMPToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }

        public void SendMPPayment()
        {
            token = AuthMPToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }
    }
}
