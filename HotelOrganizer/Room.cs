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

        public bool TryAddReservation(Reservation reservation, DateOnly reservationDate)
        {
            if (MaxPeople < reservation.People)
                return false;
            
            return mReservationPerDate.TryAdd(reservationDate, reservation);
        }

        public Reservation SearchByReservationDate(DateOnly reservationDate)
            => mReservationPerDate.GetValueOrDefault(reservationDate);

        public virtual decimal CalculateRoomPrice()
            => mReservationPerDate.Sum(pair => pair.Value.People * PricePerPerson);

        public IEnumerable<Reservation> CancelReservationById(Guid Id)
        {
            var reservationEntries = mReservationPerDate.Where(x => x.Value.ReservationId == Id).ToList();

            if (reservationEntries.Count == 0)
                return Enumerable.Empty<Reservation>();

            foreach (var x in reservationEntries)
                mReservationPerDate.Remove(x.Key);

            return reservationEntries.Select(x => x.Value).ToList();
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

        public class RoomTypeA : Room
        {
            public decimal PricePerDay { get; set; }

            

            public sealed override decimal CalculateRoomPrice()
            {
                var currentMonth = DateTime.Now.Month;

                var reservationsOfMonth = GetReservations().Where(x => x.Key.Month == currentMonth);

                var roomPrice = reservationsOfMonth.Count() * PricePerDay;

                return roomPrice;
            }
        }


    }
}
