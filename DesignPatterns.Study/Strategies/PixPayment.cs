using System;

namespace AtividadeDesignPatterns.Strategies
{
    public class PixPayment : IPaymentStrategy
    {
        private string _pixKey;

        public PixPayment(string pixKey)
        {
            _pixKey = pixKey;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"[PIX] Pagamento de R$ {amount:F2} realizado com sucesso. (Chave: {_pixKey})");
        }
    }
}