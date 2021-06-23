using ChainResponsibility.Middlewares;
using ChainResponsibility.Servidores;
using System;

namespace ChainResponsibility
{
    class Program
    {
        private static Servidor _servidor;

        static void Init()
        {
            _servidor = new Servidor();

            _servidor.Registrar("amanda@teste.com", "123");
            _servidor.Registrar("amandinha@teste.com", "123");

            Middleware middleware = new CheckUsuarioMiddleware(_servidor);

            middleware.LinkWith(new CheckPermissaoMiddleware());

            _servidor.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean finalizado = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail:");
                
                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");

                string senha = Console.ReadLine();

                finalizado = _servidor.Logar(email, senha);
            }
            while (!finalizado);

            Console.ReadLine();
        }
    }
}
