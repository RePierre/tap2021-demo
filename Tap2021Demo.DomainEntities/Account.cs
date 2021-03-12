using System;

namespace Tap2021Demo.DomainEntities
{
    public abstract class Account : IAccount
    {
        public decimal Balance { get; private set; }


        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            var fee = CalculateWithdrawalFee(amount);
            amount += fee;
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }

            this.Balance -= amount;
            return amount;
        }

        protected abstract decimal CalculateWithdrawalFee(decimal amount);
    }
}
