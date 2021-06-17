using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class BicicletaTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Bicicleta();
        }
    }
}
