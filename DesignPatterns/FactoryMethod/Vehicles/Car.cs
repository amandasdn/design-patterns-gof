using System;

namespace FactoryMethod.Vehicles
{
    public class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros.");
        }

        public void StartRoute()
        {
            Console.WriteLine($"[{nameof(Car)}]");

            GetCargo();

            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
