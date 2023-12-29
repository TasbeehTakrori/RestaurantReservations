using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; init; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
