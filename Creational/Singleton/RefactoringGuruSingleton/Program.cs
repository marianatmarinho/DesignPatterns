using System;

namespace SingletonSigleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            s1.DataItem = "s1";
            Singleton s2 = Singleton.GetInstance();
            s2.DataItem = "s2";

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.\n " + s1.DataItem + " = "+ s2.DataItem);
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances. => s1: " + s1.DataItem + " s2: " + s2.DataItem);
            }
        }
    }
}
