using Builder.Componentes;
using System.Text;

namespace Builder.Produtos
{
    class Veiculo
    {
        private ETipoVeiculo _tipoVeiculo;
        private int _assentos;
        private Motor _motor;
        private ETransmissao _transmissao;

        public ETipoVeiculo TipoVeiculo
        {
            get => _tipoVeiculo;
            set => _tipoVeiculo = value;
        }

        public int Assentos
        {
            get => _assentos;
            set => _assentos = value;
        }

        public Motor Motor
        {
            get => _motor;
            set => _motor = value;
        }

        public ETransmissao Transmissao
        {
            get => _transmissao;
            set => _transmissao = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo do Veículo: {0}\n", TipoVeiculo);
            sb.AppendFormat("Assentos: {0}\n", Assentos);
            sb.AppendFormat("Potência do Motor: {0}\n", Motor.Potencia);
            sb.AppendFormat("Transmissão: {0}\n", Transmissao);

            return sb.ToString();
        }
    }
}
