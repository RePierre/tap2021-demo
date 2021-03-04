namespace Tap2021Demo.Console
{
    public class DebitAccount : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return 0m;
        }
    }
}
