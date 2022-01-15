using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrganizer
{
    public class Room
    {
        public string CustomerName { get; set; }
        
        public int ReservationPassword { get; set; }

        public int Arrival { get; set; }

        public int DistributionDays { get; set; }

        public int People { get; set; }

    }

    public class Reservation
    {
        public int RoomPassowrd { get; set; }

        public int MaxPeople { get; set; }

    }


}
