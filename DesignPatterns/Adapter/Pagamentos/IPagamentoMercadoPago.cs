namespace Adapter.Pagamentos
{
    interface IPagamentoMercadoPago
    {
        Token AutenticarToken();

        void TransferindoDinheiro();

        void RecebendoDinheiro();
    }
}
