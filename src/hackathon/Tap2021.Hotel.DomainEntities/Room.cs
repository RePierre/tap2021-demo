using System;
using System.Collections.Generic;
using System.Text;

namespace Tap2021.Hotel.DomainEntities
{
    public class Room
    {
        public int Number { get; set; }

        public RoomType RoomType { get; set; }

        public bool HasPrivateBathroom { get; set; }
    }
}
