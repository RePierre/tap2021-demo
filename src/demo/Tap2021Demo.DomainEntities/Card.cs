using System.Collections.Generic;

namespace Tap2021Demo.DomainEntities
{
    public class Card
    {
        public Card(string cardHolder)
        {
            Holder = cardHolder;
            Accounts = new List<WithdrawableAccount>();
        }

        public string Holder { get; private set; }

        public IEnumerable<WithdrawableAccount> Accounts { get; private set; }

        public void AddAcount(SavingsAccount account)
        {
            (Accounts as List<WithdrawableAccount>).Add(account);
        }
    }
}
