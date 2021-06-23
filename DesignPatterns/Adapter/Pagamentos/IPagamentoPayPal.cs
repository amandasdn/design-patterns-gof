namespace Adapter.Pagamentos
{
    interface IPagamentoPayPal
    {
        Token AutenticarToken();

        void PayPalPagar();

        void PayPalReceber();
    }
}