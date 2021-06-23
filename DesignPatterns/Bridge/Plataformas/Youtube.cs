using System;

namespace Bridge.Plataformas
{
    class Youtube : IPlataforma
    {
        public Youtube()
        {
            ConfigurarRMTP();
            Console.WriteLine($"[{nameof(Youtube)}] Transmissão iniciada.");
        }

        public void AutenticarToken()
        {
            Console.WriteLine($"[{nameof(Youtube)}] Autorizado.");
        }

        public void ConfigurarRMTP()
        {
            AutenticarToken();

            Console.WriteLine($"[{nameof(Youtube)}] Servidor RMTP configurado.");
        }
    }
}
