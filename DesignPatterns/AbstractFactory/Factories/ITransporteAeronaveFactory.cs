using AbstractFactory.Aeronaves;
using AbstractFactory.Utils;

namespace AbstractFactory.Factories
{
    interface ITransporteAeronaveFactory
    {
        IAeronave CriarTransporteAeronave(ETipoTransporteAeronave tipoTransporteAeronave);
    }
}
