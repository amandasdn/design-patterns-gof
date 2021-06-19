using Builder.Componentes;
using Builder.Produtos;

namespace Builder.Builders
{
    class VeiculoBuilder : IBuilder
    {
        private Veiculo _veiculo = new Veiculo();

        public Veiculo GetVeiculo()
        {
            Veiculo result = _veiculo;
            Resetar();
            return result;
        }

        public void Resetar()
        {
            _veiculo = new Veiculo();
        }

        public void SetAssentos(int assentos)
        {
            _veiculo.Assentos = assentos;
        }

        public void SetMotor(Motor motor)
        {
            _veiculo.Motor = motor;
        }

        public void SetTipoVeiculo(ETipoVeiculo tipoVeiculo)
        {
            _veiculo.TipoVeiculo = tipoVeiculo;
        }

        public void SetTransmissao(ETransmissao transmissao)
        {
            _veiculo.Transmissao = transmissao;
        }
    }
}
