using Builder.Componentes;
using Builder.Produtos;

namespace Builder.Builders
{
    interface IBuilder
    {
        void Resetar();
        Veiculo GetVeiculo();
        void SetAssentos(int assentos);
        void SetMotor(Motor motor);
        void SetTransmissao(ETransmissao transmissao);
        void SetTipoVeiculo(ETipoVeiculo tipoVeiculo);
    }
}
