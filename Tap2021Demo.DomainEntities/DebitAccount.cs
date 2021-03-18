namespace Tap2021Demo.DomainEntities
{
    public class DebitAccount : Account
    {
        public DebitAccount(string iban, decimal balance, AccountHolder accountHolder) : base(iban, balance, accountHolder)
        {
        }

        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return 0m;
        }
    }
}
