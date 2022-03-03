namespace HotelOrganizer
{
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
