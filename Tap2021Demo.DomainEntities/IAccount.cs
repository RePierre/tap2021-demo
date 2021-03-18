namespace Tap2021Demo.DomainEntities
{
    public interface IAccount
    {
        public AccountHolder AccountHolder { get; }

        public string Iban { get; }

        decimal Balance { get; }

        void Deposit(decimal amount);

        decimal Withdraw(decimal amount);
    }
}