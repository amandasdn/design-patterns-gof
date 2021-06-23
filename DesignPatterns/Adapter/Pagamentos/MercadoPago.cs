using System;

namespace Adapter.Pagamentos
{
    class MercadoPago : IPagamentoMercadoPago
    {
        private Token _token;

        public Token AutenticarToken()
        {
            return new Token();
        }

        public void RecebendoDinheiro()
        {
            _token = AutenticarToken();
            Console.WriteLine($"[{nameof(MercadoPago)}] Enviando pagamento.");
        }

        public void TransferindoDinheiro()
        {
            _token = AutenticarToken();
            Console.WriteLine($"[{nameof(MercadoPago)}] Recebendo pagamento.");
        }
    }
}
