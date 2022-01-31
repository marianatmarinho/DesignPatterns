using System;

namespace ExampleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaypalPayment payment = null;

            if (args.Length > 0 && args[0] == "MP")
            {
                payment = new MercadoPagoAdapter(new MercadoPago());
            }
            else
            {
                payment = new PayonnerAdapter(new Payonner());
            }

            payment.PaypalPayment();
            payment.PaypalReceive();

            Console.ReadLine();
        }
    }
}
