using System;

namespace Adapter.Pagamentos
{
    class PayPal : IPagamentoPayPal
    {
        private Token _token;

        public Token AutenticarToken()
        {
            return new Token();
        }

        public void PayPalPagar()
        {
            _token = AutenticarToken();
            Console.WriteLine($"[{nameof(PayPal)}] Enviando pagamento.");
        }

        public void PayPalReceber()
        {
            _token = AutenticarToken();
            Console.WriteLine($"[{nameof(PayPal)}] Recebendo pagamento.");
        }
    }
}
