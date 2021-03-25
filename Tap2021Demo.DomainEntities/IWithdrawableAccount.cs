namespace Tap2021Demo.DomainEntities
{
    public interface IWithdrawableAccount
    {
        decimal Withdraw(decimal amount);
    }
}