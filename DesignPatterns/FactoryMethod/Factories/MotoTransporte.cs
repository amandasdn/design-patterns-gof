using FactoryMethod.Veiculos;

namespace FactoryMethod.Factories
{
    class MotoTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Moto();
        }
    }
}
