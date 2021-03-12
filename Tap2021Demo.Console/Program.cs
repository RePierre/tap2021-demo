namespace Tap2021Demo.Console
{
    class Program
    {
        private const int Amount = 500;

        static void Main(string[] args)
        {
            Atm.Instance.Start();
            Atm.Instance.Withdraw(100);
        }
    }
}
