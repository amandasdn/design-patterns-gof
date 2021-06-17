using System;

namespace FactoryMethod.Vehicles
{
    public class Bicicleta : IVeiculo
    {
        public void ObterCarga()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void IniciarRota()
        {
            Console.WriteLine($"[{nameof(Bicicleta)}]");

            ObterCarga();

            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
