namespace Tap2021Demo.DomainEntities
{
    public class SavingsAccount : WithdrawableAccount
    {
        public SavingsAccount(string iban, decimal balance, AccountHolder accountHolder) : base(iban, balance, accountHolder, null)
        {
        }

        protected override decimal GetWithdrawalCommissionPercent()
        {
            return 0.5m;
        }
    }
}
