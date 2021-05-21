using System;
using System.Collections.Generic;
using System.Text;

namespace Tap2021.Hotel.DomainEntities
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        // CNP
        public string IdNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
