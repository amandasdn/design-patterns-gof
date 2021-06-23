using ChainResponsibility.Servidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Middlewares
{
    class CheckPermissaoMiddleware : Middleware
    {
        public override bool Check(string email, string senha)
        {
            if (email.Equals("amanda@teste.com"))
            {
                Console.WriteLine("Permissão de administradora identificada.");
                return true;
            }

            return CheckNext(email, senha);
        }
    }
}
