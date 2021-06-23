using Bridge.Plataformas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissoes
{
    class Live : ITransmissao
    {
        protected IPlataforma _plataforma;

        public Live (IPlataforma plataforma)
        {
            _plataforma = plataforma;
        }

        public void Resultado()
        {
            Console.WriteLine($"[{nameof(Live)}] Entrou no ar.");
        }

        public void Transmitir()
        {
            Console.WriteLine($"[{nameof(Live)}] Iniciando a transmissão...");
        }
    }
}
