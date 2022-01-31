using System;

namespace SingletonMonostate
{
    class Program
    {
        static void Main(string[] args)
        {
            Monostate s1 = new Monostate();
            s1.DataItem = "s1";
            Monostate s2 = new Monostate();
            s2.DataItem = "s2";

            if (s1.DataItem == s2.DataItem && s1 != s2)
            {
                Console.WriteLine("Singleton works! Both variables contain the same instance, but the objects are differents. ");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances. => s1: " + s1.DataItem + " s2: " + s2.DataItem);
            }
        }
    }
}
