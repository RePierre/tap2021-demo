namespace Tap2021Demo.DomainEntities
{
    public class DebitAccount : WithdrawableAccount
    {
        public DebitAccount(string iban, decimal balance, AccountHolder accountHolder) : base(iban, balance, accountHolder, null)
        {
        }

        protected override decimal GetWithdrawalCommissionPercent()
        {
            return 0m;
        }
    }
}
