using FactoryMethod.Veiculos;

namespace FactoryMethod.Factories
{
    abstract class Transporte
    {
        public void IniciarTransporte()
        {
            IVeiculo veiculo = CriarTransporte();

            veiculo.IniciarRota();
        }

        protected abstract IVeiculo CriarTransporte();
    }
}
