using Adapter.Pagamentos;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // PayPal - Original
            PayPal pagamentoPayPal = new PayPal();

            pagamentoPayPal.PayPalPagar();
            pagamentoPayPal.PayPalReceber();

            Console.WriteLine("");

            // Payoneer - Adaptado para PayPal
            IPagamentoPayPal pagamentoPayoneer = new PayoneerAdapter(new Payoneer());
            
            pagamentoPayoneer.PayPalPagar();
            pagamentoPayoneer.PayPalReceber();

            Console.WriteLine("");

            // MercadoPago - Adaptado para PayPal
            IPagamentoPayPal pagamentoMercadoPago = new MercadoPagoAdapter(new MercadoPago());

            pagamentoMercadoPago.PayPalPagar();
            pagamentoMercadoPago.PayPalReceber();

            Console.ReadLine();
        }
    }
}
