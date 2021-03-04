using System.Linq;

namespace Tap2021Demo.Console
{
    public class Atm
    {
        private static Atm _instance;
        private Card _card;
        private Account _account;

        private Atm()
        {
        }

        public static Atm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Atm();
                }

                return _instance;
            }
        }

        public void Insert(Card card)
        {
            _card = card;
        }

        public void SelectAccount(Account account)
        {
            var acc = _card.Accounts.Single(a => a == account);

            _account = acc;
        }


        public void Withdraw(decimal amount)
        {
            _account.Withdraw(amount);
            System.Console.WriteLine($"Amount {amount} was withdrawn from the account");
            System.Console.WriteLine($"Remaining: {_account.Balance}");
        }

        public void Eject(Card card)
        {

        }
    }
}
