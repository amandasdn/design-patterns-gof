using FactoryMethod.Veiculos;

namespace FactoryMethod.Factories
{
    class CarroTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Carro();
        }
    }
}
