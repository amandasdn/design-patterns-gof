using ChainResponsibility.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainResponsibility.Servidores
{
    class Servidor
    {
        private Dictionary<string, string> usuarios = new();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public Boolean Logar(string email, string senha)
        {
            if(_middleware.Check(email, senha))
            {
                Console.WriteLine("Usuário logado.");
                Console.WriteLine("Seja bem-vindo!");
                return true;
            }

            return false;
        }

        public void Registrar(string email, string senha)
        {
            usuarios[email] = senha;
        }

        public Boolean TemEmail(string email)
        {
            return usuarios.ContainsKey(email);
        }

        public Boolean SenhaValida(string email, string senha)
        {
            string value = "";

            usuarios.TryGetValue(email, out value);

            return senha == value;
        }
    }
}
