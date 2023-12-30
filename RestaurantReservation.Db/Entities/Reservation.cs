using RestaurantReservation.Db.Enums;

namespace RestaurantReservation.Db.Entities
{
    public class Reservation
    {
        public int ReservationId { get; init; }

        public DateTime ReservationDate { get; set; }

        public PartySize PartySize { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int TableId { get; set; }

        public Table Table { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
