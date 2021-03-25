using System;
using System.Diagnostics;

namespace Tap2021Demo.DomainEntities
{
    public abstract class WithdrawableAccount : Account
    {
        protected WithdrawableAccount(string iban, AccountHolder accountHolder) : this(iban, 0m, accountHolder, null)
        {
        }

        protected WithdrawableAccount(string iban, decimal balance, AccountHolder accountHolder, IWithdrawalAmountCalculator withdrawalAmountCalculator) : base(iban, balance, accountHolder)
        {
            Debug.Assert(withdrawalAmountCalculator != null);

            AmountCalculator = withdrawalAmountCalculator;
        }

        public decimal WithdrawalCommissionPercent
        {
            get
            {
                var fee = GetWithdrawalCommissionPercent();

                return fee;
            }
        }

        public IWithdrawalAmountCalculator AmountCalculator { get; set; }

        public decimal Withdraw(decimal amount)
        {
            return WithdrawAmount(amount);
        }

        protected abstract decimal GetWithdrawalCommissionPercent();

        protected virtual decimal WithdrawAmount(decimal amount)
        {
            amount = AmountCalculator.CalculateWithdrawalAmount(amount, WithdrawalCommissionPercent);
            ValidateWithdrawalAmount(amount);

            Balance -= amount;
            return amount;
        }

        private void ValidateWithdrawalAmount(decimal amount)
        {
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }
        }
    }
}
