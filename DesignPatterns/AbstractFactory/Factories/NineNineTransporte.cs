using AbstractFactory.Aeronaves;
using AbstractFactory.Utils;
using AbstractFactory.Veiculos;
using System;

namespace AbstractFactory.Factories
{
    class NineNineTransporte : ITransporteVeiculoFactory, ITransporteAeronaveFactory
    {
        public NineNineTransporte()
        {
            Console.WriteLine($"[{nameof(NineNineTransporte)}]");
        }

        public IAeronave CriarTransporteAeronave(ETipoTransporteAeronave tipoTransporteAeronave)
            => tipoTransporteAeronave switch
            {
                ETipoTransporteAeronave.Aviao => new Aviao(),
                ETipoTransporteAeronave.Helicoptero => new Helicoptero(),
                _ => null
            };

        public IVeiculo CriarTransporteVeiculo(ETipoTransporteVeiculo tipoTransporteVeiculo)
            => tipoTransporteVeiculo switch
            {
                ETipoTransporteVeiculo.Carro => new Carro(),
                ETipoTransporteVeiculo.Moto => new Moto(),
                _ => null
            };
    }
}
