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

        public decimal CalculateRoomPrice()
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
    }


}
