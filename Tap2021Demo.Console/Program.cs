namespace Tap2021Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm.Instance.Start();
            Atm.Instance.Withdraw(100);

        }
    }
}
