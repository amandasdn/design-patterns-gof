using System;

namespace Bridge.Plataformas
{
    class Twitch : IPlataforma
    {
        public Twitch()
        {
            ConfigurarRMTP();
            Console.WriteLine($"[{nameof(Twitch)}] Transmissão iniciada.");
        }

        public void AutenticarToken()
        {
            Console.WriteLine($"[{nameof(Twitch)}] Autorizado.");
        }

        public void ConfigurarRMTP()
        {
            AutenticarToken();

            Console.WriteLine($"[{nameof(Twitch)}] Servidor RMTP configurado.");
        }
    }
}
