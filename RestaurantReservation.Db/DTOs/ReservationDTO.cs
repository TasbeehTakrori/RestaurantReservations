using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Domain.DTOs
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }
        public DateTime ReservationDate { get; set; }
        public PartySize PartySize { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
        public int RestaurantId { get; set; }

        public override string ToString()
        {
            return $"ReservationId: {ReservationId}, ReservationDate: {ReservationDate}, PartySize: {PartySize}, CustomerId: {CustomerId}, TableId: {TableId}, RestaurantId: {RestaurantId}";
        }
    }
}
