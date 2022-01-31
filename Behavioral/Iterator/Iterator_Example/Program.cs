using System;

namespace Iterator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection colecao = new ConcreteCollection();

            colecao.AddCliente(new Cliente("Pedro", 10));
            colecao.AddCliente(new Cliente("Maria", 11));
            colecao.AddCliente(new Cliente("Manoel", 12));
            colecao.AddCliente(new Cliente("Miriam", 13));
            colecao.AddCliente(new Cliente("Jefferson", 14));

            Iterator iterator = colecao.CreateIterator();

            Console.WriteLine("### Usando o padrão Iterador ###\n");
            Console.WriteLine("Pressione algo para iniciar");
            Console.ReadKey();

            Console.WriteLine("Iterando sobre a coleção de Clientes :\n ");

            for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
            {
                Console.WriteLine($"ID : {cliente.Id} & Nome : {cliente.Nome}");
            }
            Console.Read();
        }
    }
}
