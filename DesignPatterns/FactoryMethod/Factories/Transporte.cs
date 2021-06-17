using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    abstract class Transporte
    {
        public void IniciarTransporte()
        {
            IVeiculo vehicle = CriarTransporte();

            vehicle.IniciarRota();
        }

        protected abstract IVeiculo CriarTransporte();
    }
}
