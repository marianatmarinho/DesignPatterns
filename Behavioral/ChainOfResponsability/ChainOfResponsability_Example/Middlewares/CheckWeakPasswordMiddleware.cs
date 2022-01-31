using ChainOfResponsability_Example.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability_Example.Middlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        private Server _server;
        public CheckWeakPasswordMiddleware(Server server)
        {
            _server = server;
        }
        public override bool Check(string email, string password)
        {
            if(_server.IsWeakPassword(password))
            {
                Console.WriteLine("Atenção: senha fraca");
            }
            return CheckNext(email, password);
        }
    }
}
