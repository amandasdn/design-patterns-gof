using FactoryMethod.Vehicles;

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
