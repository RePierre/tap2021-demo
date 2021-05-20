namespace Tap2021Demo.DomainEntities
{
    public sealed class WithdrawalAmountCalculator : IWithdrawalAmountCalculator
    {
        public decimal CalculateWithdrawalAmount(decimal amount, decimal withdrawalCommissionPercent)
        {
            withdrawalCommissionPercent = CapCommission(withdrawalCommissionPercent);
            return amount + amount * withdrawalCommissionPercent;
        }

        private decimal CapCommission(decimal withdrawalCommissionPercent)
        {
            if (withdrawalCommissionPercent > 0.1m)
            {
                withdrawalCommissionPercent = 0.1m;
            }

            return withdrawalCommissionPercent;
        }
    }
}
