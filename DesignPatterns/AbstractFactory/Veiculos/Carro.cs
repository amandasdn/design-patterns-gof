using System;

namespace AbstractFactory.Veiculos
{
    class Carro : IVeiculo
    {
        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Carro)}]");

            ObterCarga();

            Console.WriteLine("Rota iniciada.");
        }

        public void ObterCarga()
        {
            Console.WriteLine("Passageiros foram obtidos.");
        }
    }
}
