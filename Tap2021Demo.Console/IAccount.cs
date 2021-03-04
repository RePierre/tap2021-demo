namespace Tap2021Demo.Console
{
    public interface IAccount
    {
        decimal Balance { get; }

        void Deposit(decimal amount);

        decimal Withdraw(decimal amount);
    }
}