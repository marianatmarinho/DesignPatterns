using System;

namespace Proxy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Exemplo de implementação do padrão Proxy ###");

            //acesso programador
            Console.WriteLine("\n Funcionário com perfil Programador");
            Employee employee1 = new Employee("João", "123456", "Programador");
            SharedFolderProxy proxy1 = new SharedFolderProxy(employee1);
            proxy1.ReadWriteOperation();

            //acesso usuario
            Console.WriteLine("\n Funcionário com perfil Usuário");
            Employee employee2 = new Employee("Maria", "123456", "Usuário");
            SharedFolderProxy proxy2 = new SharedFolderProxy(employee2);
            proxy2.ReadWriteOperation();

            //acesso CEO
            Console.WriteLine("\n Funcionário com perfil CEO");
            Employee employee3 = new Employee("Paulo", "123456", "CEO");
            SharedFolderProxy proxy3 = new SharedFolderProxy(employee3);
            proxy3.ReadWriteOperation();

            Console.Read();
        }
    }
}
