namespace Tap2021Demo.Console
{
    class Program
    {
        private const int Amount = 500;

        static void Main(string[] args)
        {

            //Prepare
            var account = new SavingsAccount();
            account.Deposit(200);
            var card = new Card("Andrei Ionut");
            card.AddAcount(account);

            // Withdraw from ATM
            Atm.Instance.Insert(card);
            Atm.Instance.SelectAccount(account);
            Atm.Instance.Withdraw(100);
        }
    }
}
