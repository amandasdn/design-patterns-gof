using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aeronaves
{
    class Helicoptero : IAeronave
    {
        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Helicoptero)}]");

            VerificarClima();
            ObterCarga();

            Console.WriteLine("Iniciando decolagem.");
        }

        public void ObterCarga()
        {
            Console.WriteLine("Passageiros à bordo.");
        }

        public void VerificarClima()
        {
            Console.WriteLine("Clima verificado. Ventos a 10km. Ok!");
        }
    }
}
