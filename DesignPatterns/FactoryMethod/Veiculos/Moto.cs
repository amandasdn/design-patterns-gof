using System;

namespace FactoryMethod.Veiculos
{
    public class Moto : IVeiculo
    {
        public void ObterCarga()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Moto)}]");

            ObterCarga();

            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
