namespace RestaurantReservation.Db.Models
{
    public class Table
    {
        public int TableId { get; init; }

        public int Capacity { get; init; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
