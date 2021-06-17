using FactoryMethod.Factories;
using FactoryMethod.Utils;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
            args = new string[] { TransportType.Motorcycle };
            #endif

            Transport transport = null;

            if (args.Length > 0)
            {
                transport = args[0] switch
                {
                    TransportType.Car => new CarTransport(),
                    TransportType.Motorcycle => new MotorcycleTransport(),
                    TransportType.Bicycle => new BicycleTransport(),
                    _ => null
                };

                if (transport == null)
                {
                    Console.WriteLine("Selecione um serviço válido.");
                }
                else
                {
                    transport.StartTransport();
                }
            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço.");
            }

            Console.ReadLine();
        }
    }
}
