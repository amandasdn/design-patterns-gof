using System;

namespace Adapter.Pagamentos
{
    class Payoneer : IPagamentoPayoneer
    {
        private Token _token;

        public Token AutenticarToken()
        {
            return new Token();
        }

        public void EnviarPagamento()
        {
            _token = AutenticarToken();
            Console.WriteLine($"[{nameof(Payoneer)}] Enviando pagamento.");
        }

        public void ReceberPagamento()
        {
            _token = AutenticarToken();
            Console.WriteLine($"[{nameof(Payoneer)}] Recebendo pagamento.");
        }
    }
}
