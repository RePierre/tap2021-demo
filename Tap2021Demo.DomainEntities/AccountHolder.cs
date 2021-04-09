using System;

namespace Tap2021Demo.DomainEntities
{
    public class AccountHolder
    {
        public AccountHolder(Guid id, string idNo, string firstName, string lastName)
        {
            Id = id;
            IdNo = idNo;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Guid Id { get; private set; }

        public string IdNo { get; private set; }

    }
}
