using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Application.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; init; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; }
    }
}
