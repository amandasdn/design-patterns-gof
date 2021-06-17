using FactoryMethod.Veiculos;

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
