namespace HotelOrganizer
{
        public class RoomTypeC : Room
        {
            public int MinPeople { get; set; }

            public int MinDays { get; set; }

            public override bool TryAddReservation(Reservation reservation)
            {

                if(MinDays > reservation.DistributionDays || MinPeople > reservation.People)
                    return false;

                return base.TryAddReservation(reservation);
            }

            


        }

}
