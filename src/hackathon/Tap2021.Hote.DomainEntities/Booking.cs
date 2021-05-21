using System;
using System.Collections.Generic;
using System.Text;

namespace Tap2021.Hote.DomainEntities
{
    public class Booking
    {
        public int Number { get; set; }

        public int RoomNumber { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public BookingStatus Status { get; set; }
    }
}
