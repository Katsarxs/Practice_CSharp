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

        public class RoomTypeB : RoomTypeA
        {
            public decimal DiscountPerDay { get; set; }

            public decimal PricePerDayThreshold => PricePerDay / 2;

            public override Reservation CancelReservationById(Guid Id)
            {
                return null;
            }

            public override decimal CalculateRoomPrice()
            {

                var currentMonth = DateTime.Now.Month;

                var reservationsOfMonth = GetReservations().Where(x => x.Key.Month == currentMonth).Select(x => x.Value);

                var monthlyPrice = 0m;

                var priceDiscounted = PricePerDay * DiscountPerDay;

                foreach (var reservation in reservationsOfMonth)
                {
                    var currentPrice = PricePerDay;

                    var currentReservationPrice = 0m;
                    for (int i = 0; i < reservation.DistributionDays; i++)
                    {
                        currentReservationPrice += currentPrice;

                        if ((currentPrice - priceDiscounted) > PricePerDayThreshold)
                            currentPrice -= priceDiscounted;
                        else
                            currentPrice = PricePerDayThreshold;
                    }

                    monthlyPrice += currentReservationPrice;
                }


                return monthlyPrice;
            }
        }


    }
}
