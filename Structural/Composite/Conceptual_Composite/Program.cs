using System;

namespace Conceptual_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component");
            client.ClientCode(leaf);

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: now I've got a composite tree:");

            Console.Write("Client: I dot't need check the components classes even when managing the tree:\n");
            client.ClienteCode2(tree, leaf);
        }
    }
}
