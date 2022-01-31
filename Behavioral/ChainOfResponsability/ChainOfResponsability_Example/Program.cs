using ChainOfResponsability_Example.Middlewares;
using ChainOfResponsability_Example.Servers;
using System;

namespace ChainOfResponsability_Example
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@teste.com.br", "123456");
            server.RegisterUser("user@teste.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware()).LinkWith(new CheckWeakPasswordMiddleware(server));

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {
            Init();
            Boolean done = false;
            do
            {
                Console.WriteLine("Digite seu e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            } while (!done);

            Console.ReadLine();
        }
    }
}
