namespace Tap2021Demo.DomainEntities
{
    public interface IAccount
    {
        decimal Balance { get; }

        void Deposit(decimal amount);

        decimal Withdraw(decimal amount);
    }
}