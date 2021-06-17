using System;

namespace FactoryMethod.Veiculos
{
    public class Carro : IVeiculo
    {
        public void ObterCarga()
        {
            Console.WriteLine("Pegamos os passageiros.");
        }

        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Carro)}]");

            ObterCarga();

            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
