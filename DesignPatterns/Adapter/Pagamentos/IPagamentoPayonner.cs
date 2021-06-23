namespace Adapter.Pagamentos
{
    interface IPagamentoPayoneer
    {
        Token AutenticarToken();

        void EnviarPagamento();

        void ReceberPagamento();
    }
}