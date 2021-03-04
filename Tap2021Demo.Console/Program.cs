using System;

namespace Tap2021Demo.Console
{
    class Program
    {
        private const int Amount = 500;

        static void Main(string[] args)
        {
            var account = new SavingsAccount();
            account.Deposit(200);

            System.Console.WriteLine($"Disponibil: {account.Balance} RON");

            try
            {
                account.Withdraw(100);

            }
            catch (InvalidOperationException)
            {
                System.Console.WriteLine("Fonduri insuficiente!");
            }
            System.Console.WriteLine($"Disponibil: {account.Balance} RON");
        }
    }
}
