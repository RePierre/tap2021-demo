namespace Tap2021Demo.DomainEntities
{
    public interface IWithdrawalAmountCalculator
    {
        decimal CalculateWithdrawalAmount(decimal amount, decimal withdrawalCommissionPercent);
    }
}