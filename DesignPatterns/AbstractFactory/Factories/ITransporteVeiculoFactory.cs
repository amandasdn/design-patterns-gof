using AbstractFactory.Utils;
using AbstractFactory.Veiculos;

namespace AbstractFactory.Factories
{
    interface ITransporteVeiculoFactory
    {
        IVeiculo CriarTransporteVeiculo(ETipoTransporteVeiculo tipoTransporteVeiculo);
    }
}
