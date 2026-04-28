using System;
using AtividadeDesignPatterns.Models;
using AtividadeDesignPatterns.Strategies;

namespace AtividadeDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o sistema de pagamentos...\n");

            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("--- Compra 1: Jogo na Steam ---");
            cart.SetPaymentStrategy(new PixPayment("email@exemplo.com"));
            cart.Checkout(199.90);

            Console.WriteLine("\n--- Compra 2: Peça de Hardware ---");
            cart.SetPaymentStrategy(new CreditCardPayment("1234567890129988"));
            cart.Checkout(850.50);

            Console.WriteLine("\n--- Compra 3: Cadeira Gamer ---");
            cart.SetPaymentStrategy(new BoletoPayment());
            cart.Checkout(1200.00);

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}