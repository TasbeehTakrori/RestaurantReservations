using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class OrderItem
    {
        [Key]
        public int OrderItemId { get; init; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        public int MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; }
    }
}
