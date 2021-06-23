using Bridge.Plataformas;
using Bridge.Transmissoes;
using System;

namespace Bridge
{
    class Program
    {
        static void IniciarLive(IPlataforma plataforma)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(plataforma);

            live.Transmitir();
            live.Resultado();

            Console.WriteLine("");
        }

        static void IniciarLiveAvancada(IPlataforma plataforma)
        {
            Console.WriteLine("Aguarde...");

            LiveAvancada live = new LiveAvancada(plataforma);

            live.Transmitir();
            live.Resultado();
            live.Legenda();
            live.Comentarios();

            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            IniciarLive(new Youtube());
            IniciarLiveAvancada(new Twitch());
            IniciarLive(new Facebook());

            Console.ReadLine();
        }
    }
}
