namespace RestaurantReservation.Application.Models
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public MenuItemDTO MenuItem { get; set; }
    }
}
