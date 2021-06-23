using System;

namespace Bridge.Plataformas
{
    class Facebook : IPlataforma
    {
        public Facebook()
        {
            ConfigurarRMTP();
            Console.WriteLine($"[{nameof(Facebook)}] Transmissão iniciada.");
        }

        public void AutenticarToken()
        {
            Console.WriteLine($"[{nameof(Facebook)}] Autorizado.");
        }

        public void ConfigurarRMTP()
        {
            AutenticarToken();

            Console.WriteLine($"[{nameof(Facebook)}] Servidor RMTP configurado.");
        }
    }
}
