namespace HotelOrganizer
{
    public class Room
    {

        public Guid RoomId { get; } = Guid.NewGuid();

        public int MaxPeople { get; set; } 

        public decimal PricePerPerson { get; set; }

        private readonly Dictionary<DateOnly, Reservation> mReservationPerDate = new();

        public IDictionary<DateOnly, Reservation> GetReservations()
            => mReservationPerDate;

        public virtual bool TryAddReservation(Reservation reservation)
        {
            if (MaxPeople < reservation.People)
                return false;
            
            return mReservationPerDate.TryAdd(reservation.Arrival.ToDateOnly(), reservation);
        }

        public Reservation SearchByReservationDate(DateOnly reservationDate)
            => mReservationPerDate.GetValueOrDefault(reservationDate);

        public virtual decimal CalculateRoomPrice()
            => mReservationPerDate.Sum(pair => pair.Value.People * PricePerPerson);
        
        public virtual Reservation CancelReservationById(Guid Id)
        {
            var reservationExists = mReservationPerDate.Any(x => x.Value.ReservationId == Id);

            if (!reservationExists)
                return null;

            return mReservationPerDate.First(x => x.Value.ReservationId == Id).Value;
        }


        public decimal GetRoomReservationPercentangePerMonth(DateOnly date)
        {
            var reservationsPerMonthAndPerYear = mReservationPerDate.Where(x => x.Key.Month == date.Month)
                .Where(x => x.Key.Year == date.Year)
                .ToList();

            return reservationsPerMonthAndPerYear.Count / date.GetDaysOfMonth();
        }

        public decimal GetRoomReservationPercentangePerYear(int year)
        {
            var reservationsPerYear = mReservationPerDate
                .Where(x => x.Key.Year == year)
                .ToList();

            var newYear = new DateOnly(year, 1, 1).AddYears(1).AddDays(-1);

            return reservationsPerYear.Count / newYear.DayOfYear;
        }


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

        public class Hotel
        {
            public string Name { get; set; }

            private readonly List<Room> mRooms = new List<Room>();

            public IEnumerable<Room> Rooms => mRooms;

            private readonly List<Reservation> mReservations = new List<Reservation>();

            public IEnumerable<Reservation> Reservations => mReservations;

            public void AddRoom(Room room) => mRooms.Add(room);

            public Room GetRoomById(Guid roomId) => mRooms.FirstOrDefault(x => x.RoomId == roomId);

            public Reservation GetReservationById(Guid reservationId) => mReservations.FirstOrDefault(x => x.ReservationId == reservationId);

            public bool TryAddReservationToRoom(Reservation reservation, Guid roomId)
            {
                var room = GetRoomById(roomId);

                if (room == null)

                    return false;

                return room.TryAddReservation(reservation);
            }




        }


    }
}
