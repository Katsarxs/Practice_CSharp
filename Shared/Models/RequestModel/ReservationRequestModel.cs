namespace Shared
{
    public class ReservationRequestModel
    {

        public string CustomerName { get; set; }

        public Guid ReservationId { get; } = Guid.NewGuid();

        public DateTime Arrival { get; set; }

        public int DistributionDays { get; set; }

        public int People { get; set; }

        public RoomRequestModel Room { get; set; }
    }
}