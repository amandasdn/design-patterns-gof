using AbstractFactory.Aeronaves;
using AbstractFactory.Factories;
using AbstractFactory.Utils;
using AbstractFactory.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    class Application
    {
        private IVeiculo veiculo;
        private IAeronave aeronave;

        public Application(ITransporteVeiculoFactory transporteVeiculoFactory, ETipoTransporteVeiculo tipoTransporteVeiculo)
        {
            veiculo = transporteVeiculoFactory.CriarTransporteVeiculo(tipoTransporteVeiculo);
        }

        public Application(ITransporteAeronaveFactory transporteAeronaveFactory, ETipoTransporteAeronave tipoTransporteAeronave)
        {
            aeronave = transporteAeronaveFactory.CriarTransporteAeronave(tipoTransporteAeronave);
        }

        public void IniciarRota(ETipoTransporte tipoTransporte)
        {
            if (veiculo != null && tipoTransporte.Equals(ETipoTransporte.Veiculo))
            {
                veiculo.IniciarRota();
            }
            else if (aeronave != null && tipoTransporte.Equals(ETipoTransporte.Aeronave))
            {
                aeronave.IniciarRota();
            }
            else
            {
                Console.WriteLine("Tipo de transporte inválido.");
            }
        }
    }
}
