namespace Tap2021Demo.DomainEntities
{
    public class AccountHolder
    {
        public AccountHolder(string idNo, string firstName, string lastName)
        {
            IdNo = idNo;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string IdNo { get; private set; }

    }
}
