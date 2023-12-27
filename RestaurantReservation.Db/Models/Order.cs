using EntityFrameworkCore.Projectables;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; init; }

        [Required]
        public int ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [Projectable]
        public decimal TotalAmount => OrderItems.Sum(oi => oi.MenuItem.Price * oi.Quantity);


    }
}
