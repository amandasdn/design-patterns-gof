using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aeronaves
{
    class Aviao : IAeronave
    {
        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Aviao)}]");

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
            Console.WriteLine("Clima verificado. Ventos a 30km. Ok!");
        }
    }
}
