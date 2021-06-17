using AbstractFactory.App;
using AbstractFactory.Factories;
using AbstractFactory.Utils;
using System;

namespace AbstractFactory
{
    class Program
    {
        private static ETipoTransporte TipoTransporte = ETipoTransporte.Veiculo;
        private static ETipoTransporteVeiculo TipoVeiculo = ETipoTransporteVeiculo.Carro;
        private static ETipoTransporteAeronave TipoAeronave = ETipoTransporteAeronave.Helicoptero;
        private static string Companhia = TipoCompanhia.Lime;

        static Application ConfigurarApp()
        {
            if (TipoTransporte.Equals(ETipoTransporte.Aeronave))
            {
                ITransporteAeronaveFactory aeronaveFactory;

                aeronaveFactory = Companhia switch
                {
                    TipoCompanhia.Uber => new UberTransporte(),
                    TipoCompanhia.NineNine => new NineNineTransporte(),
                    _ => new LimeTransporte()
                };

                return new Application(aeronaveFactory, TipoAeronave);
            }
            else
            {
                ITransporteVeiculoFactory veiculoFactory;

                veiculoFactory = Companhia switch
                {
                    TipoCompanhia.Uber => new UberTransporte(),
                    TipoCompanhia.NineNine => new NineNineTransporte(),
                    _ => new LimeTransporte()
                };

                return new Application(veiculoFactory, TipoVeiculo);
            }
        }

        static void Main(string[] args)
        {
            Application app = ConfigurarApp();

            app.IniciarRota(TipoTransporte);

            Console.ReadLine();
        }
    }
}
