using System;

namespace Adapter.Pagamentos
{
    class PayoneerAdapter : IPagamentoPayPal
    {
        private Payoneer _payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            _payoneer = payoneer;

            Console.WriteLine($"[{nameof(PayoneerAdapter)}] Passou pelo adaptador.");
        }

        public Token AutenticarToken()
        {
            return _payoneer.AutenticarToken();
        }

        public void PayPalPagar()
        {
            _payoneer.EnviarPagamento();
        }

        public void PayPalReceber()
        {
            _payoneer.ReceberPagamento();
        }
    }
}
