using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability_Example.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@teste.com.br"))
            {
                Console.WriteLine("Seja Bem-Vindo ADMINISTRADOR");
            }
            else
            {
                Console.WriteLine("Seja Bem-Vindo USUARIO");
            }

            return CheckNext(email, password);
        }
    }
}
