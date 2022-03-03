using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrganizer
{
    public class Reservation
    {
        public Reservation()
        {

        }

        public string CustomerName { get; set; }

        public Guid ReservationId { get; } = Guid.NewGuid();

        public DateTime Arrival { get; set; }

        public int DistributionDays { get; set; }

        public int People { get; set; }

        public Room Room { get; set; }

    }


}
