using System;

namespace AbstractFactory.Veiculos
{
    class Moto : IVeiculo
    {
        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Moto)}]");

            ObterCarga();

            Console.WriteLine("Rota iniciada.");
        }

        public void ObterCarga()
        {
            Console.WriteLine("Encomenda foi obtida.");
        }
    }
}
