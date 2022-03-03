namespace Shared
{
    public class RoomRequestModel
    {
        public Guid RoomId { get; } = Guid.NewGuid();

        public int MaxPeople { get; set; }

        public decimal PricePerPerson { get; set; }
    }
}