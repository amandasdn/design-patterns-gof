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
            args = new string[] { TipoTransporte.Moto };
            #endif

            Transporte transporte = null;

            if (args.Length > 0)
            {
                transporte = args[0] switch
                {
                    TipoTransporte.Carro => new CarroTransporte(),
                    TipoTransporte.Moto => new MotoTransporte(),
                    TipoTransporte.Bicicleta => new BicicletaTransporte(),
                    _ => null
                };

                if (transporte == null)
                {
                    Console.WriteLine("Selecione um serviço válido.");
                }
                else
                {
                    transporte.IniciarTransporte();
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
