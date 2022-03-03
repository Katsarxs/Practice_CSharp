namespace HotelOrganizer
{
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
