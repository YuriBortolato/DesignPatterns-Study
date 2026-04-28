using System;

namespace AtividadeDesignPatterns
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o sistema de pagamentos...\n");

            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("--- Compra 1: Jogo na Steam ---");
            cart.SetPaymentStrategy(new PixPayment("seuemail@exemplo.com"));
            cart.Checkout(199.90);

            Console.WriteLine("\n--- Compra 2: Peça de Hardware ---");

            cart.SetPaymentStrategy(new CreditCardPayment("1234567890129988"));
            cart.Checkout(850.50);

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}