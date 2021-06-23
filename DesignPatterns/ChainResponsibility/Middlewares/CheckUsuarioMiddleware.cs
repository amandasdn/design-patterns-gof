using ChainResponsibility.Servidores;
using System;

namespace ChainResponsibility.Middlewares
{
    class CheckUsuarioMiddleware : Middleware
    {
        private Servidor _servidor;
    
        public CheckUsuarioMiddleware (Servidor servidor)
        {
            _servidor = servidor;
        }

        public override bool Check(string email, string senha)
        {
            if (!_servidor.TemEmail(email))
            {
                Console.WriteLine("E-mail inválido.");
                return false;
            }

            if (!_servidor.SenhaValida(email, senha))
            {
                Console.WriteLine("E-mail e/ou senha inválidos.");
                return false;
            }

            return CheckNext(email, senha);
        }
    }
}
