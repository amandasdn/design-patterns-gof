using AbstractFactory.Aeronaves;
using AbstractFactory.Utils;
using AbstractFactory.Veiculos;
using System;

namespace AbstractFactory.Factories
{
    class UberTransporte : ITransporteVeiculoFactory, ITransporteAeronaveFactory
    {
        public UberTransporte()
        {
            Console.WriteLine($"[{nameof(UberTransporte)}]");
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
