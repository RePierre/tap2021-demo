using System;

namespace Tap2021Demo.DomainEntities
{

    public abstract class Account : IAccount
    {
        public Account(string iban, AccountHolder accountHolder) : this(iban, 0m, accountHolder)
        {

        }

        protected Account(string iban, decimal balance, AccountHolder accountHolder)
        {
            Iban = iban;
            Balance = balance;
            AccountHolder = accountHolder;
        }

        public decimal Balance { get; private set; }

        public string Iban { get; private set; }

        public AccountHolder AccountHolder { get; private set; }

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
