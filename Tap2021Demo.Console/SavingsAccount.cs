namespace Tap2021Demo.Console
{
    public class SavingsAccount : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount * 0.5m / 100m;
        }
    }
}
