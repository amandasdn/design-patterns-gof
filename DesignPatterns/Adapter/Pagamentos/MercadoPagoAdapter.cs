using System;

namespace Adapter.Pagamentos
{
    class MercadoPagoAdapter : IPagamentoPayPal
    {
        private MercadoPago _mercadoPago;

        public MercadoPagoAdapter (MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;

            Console.WriteLine($"[{nameof(PayoneerAdapter)}] Passou pelo adaptador.");
        }

        public Token AutenticarToken()
        {
            return _mercadoPago.AutenticarToken();
        }

        public void PayPalPagar()
        {
            _mercadoPago.TransferindoDinheiro();
        }

        public void PayPalReceber()
        {
            _mercadoPago.RecebendoDinheiro();
        }
    }
}
