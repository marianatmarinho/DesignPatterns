using System;

namespace Command_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();

            Order order = new Order(chef, "Prato");
            Waiter waiter = new Waiter(order);
            waiter.Invoke();

            order = new Order(chef, "Sobremesa");
            waiter = new Waiter(order);
            waiter.Invoke();

            Console.ReadKey();
        }
    }
}
