namespace Tap2021Demo.DomainEntities
{
    public class DepositAcccount : Account
    {
        public DepositAcccount(string iban, AccountHolder accountHolder) : base(iban, accountHolder)
        {
        }
    }
}
