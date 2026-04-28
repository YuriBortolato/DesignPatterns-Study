using System;
using AtividadeDesignPatterns.Strategies; 

namespace AtividadeDesignPatterns.Models
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout(double amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Erro: Por favor, selecione uma forma de pagamento.");
                return;
            }

            _paymentStrategy.Pay(amount);
        }
    }
}