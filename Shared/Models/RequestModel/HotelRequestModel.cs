using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class HotelRequestModel
    {
        public string Name { get; set; }

        public IEnumerable<RoomRequestModel> Rooms { get; set; }

        public IEnumerable<ReservationRequestModel> Reservations { get; set; }
    }
}
