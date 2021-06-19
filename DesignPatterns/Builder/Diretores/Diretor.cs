using Builder.Builders;
using Builder.Componentes;

namespace Builder.Diretores
{
    class Diretor
    {
        IBuilder builder;

        public Diretor(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstruirCarroSedan()
        {
            builder.SetTipoVeiculo(ETipoVeiculo.SEDAN);
            builder.SetMotor(new Motor(2000));
            builder.SetAssentos(5);
            builder.SetTransmissao(ETransmissao.AUTOMATICO);
        }

        public void ConstruirCaminhao()
        {
            builder.SetTipoVeiculo(ETipoVeiculo.TRUCK);
            builder.SetMotor(new Motor(5000));
            builder.SetAssentos(2);
            builder.SetTransmissao(ETransmissao.MANUAL);
        }
    }
}
