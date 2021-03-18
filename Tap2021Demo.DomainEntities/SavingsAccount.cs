namespace Tap2021Demo.DomainEntities
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string iban, decimal balance, AccountHolder accountHolder) : base(iban, balance, accountHolder)
        {
        }

        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount * 0.5m / 100m;
        }
    }
}
