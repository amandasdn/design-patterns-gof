using System;

namespace FactoryMethod.Vehicles
{
    public class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            Console.WriteLine($"[{nameof(Bicycle)}]");

            GetCargo();

            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
