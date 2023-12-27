using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class MenuItem
    {
        [Key]
        public int MenuItemId { get; init; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [Required]
        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
