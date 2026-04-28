using System;

namespace AtividadeDesignPatterns.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void Pay(double amount)
        {
            string ultimosDigitos = _cardNumber.Substring(_cardNumber.Length - 4);
            Console.WriteLine($"[CARTÃO] Pagamento de R$ {amount:F2} aprovado no Cartão de Crédito (Final: {ultimosDigitos}).");
        }
    }
}