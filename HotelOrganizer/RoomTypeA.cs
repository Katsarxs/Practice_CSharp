using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrganizer
{
    public class RoomTypeA : Room
    {
        public decimal PricePerDay { get; set; }



        public override decimal CalculateRoomPrice()
        {
            var currentMonth = DateTime.Now.Month;

            var reservationsOfMonth = GetReservations().Where(x => x.Key.Month == currentMonth);

            var roomPrice = reservationsOfMonth.Count() * PricePerDay;

            return roomPrice;
        }
    }
}
