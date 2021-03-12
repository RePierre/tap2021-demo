using System.Collections.Generic;

namespace Tap2021Demo.DomainEntities
{
    public class Card
    {
        public Card(string cardHolder)
        {
            Holder = cardHolder;
            Accounts = new List<Account>();
        }

        public string Holder { get; private set; }

        public IEnumerable<Account> Accounts { get; private set; }

        public void AddAcount(SavingsAccount account)
        {
            (Accounts as List<Account>).Add(account);
        }
    }
}
