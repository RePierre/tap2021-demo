using System;

namespace Tap2021.Hote.DomainEntities
{
    public class BookingCustomer
    {
        public Guid Id { get; set; }

        public int BookingNumber { get; set; }

        public Guid CustomerId { get; set; }

        public AgeCategory AgeCategory { get; set; }

        public bool IsMainCustomer { get; set; }
    }
}
