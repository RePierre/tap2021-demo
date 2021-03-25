using System.Linq;
using Tap2021Demo.DomainEntities;

namespace Tap2021Demo.Console
{
    public class Atm
    {
        private static Atm _instance;
        private Card _card;
        private WithdrawableAccount _account;

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

        public void Start()
        {
            //Prepare
            var account = new SavingsAccount(string.Empty, 0m, new AccountHolder(string.Empty, string.Empty, string.Empty));
            account.Deposit(200);
            var card = new Card("Andrei Ionut");
            card.AddAcount(account);

            _card = card;
            this.SelectAccount(account);
        }

        public void SelectAccount(WithdrawableAccount account)
        {
            var acc = _card.Accounts.Single(a => a == account);
            _account = acc;
        }

        class DummyAmountCalculator : IWithdrawalAmountCalculator
        {
            public new decimal CalculateWithdrawalAmount(decimal amount, decimal withdrawalCommissionPercent)
            {
                return amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            _account.AmountCalculator = new DummyAmountCalculator();
            _account.Withdraw(amount);

            System.Console.WriteLine($"Amount {amount} was withdrawn from the account");
            System.Console.WriteLine($"Remaining: {_account.Balance}");
        }

        public void Eject(Card card)
        {

        }
    }
}
