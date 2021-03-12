namespace Tap2021Demo.DomainEntities
{
    public class SavingsAccount : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount * 0.5m / 100m;
        }
    }
}
