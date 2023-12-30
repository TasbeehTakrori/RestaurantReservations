using EntityFrameworkCore.Projectables;

namespace RestaurantReservation.Db.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; init; }

        public int ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [Projectable]
        public decimal TotalAmount => OrderItems.Sum(oi => oi.MenuItem.Price * oi.Quantity);
    }
}
