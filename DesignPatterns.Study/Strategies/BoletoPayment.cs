using System;

namespace AtividadeDesignPatterns.Strategies
{
    public class BoletoPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"[BOLETO] Boleto gerado no valor de R$ {amount:F2}. Aguardando compensação.");
        }
    }
}