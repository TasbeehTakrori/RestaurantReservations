using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.DTOs
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }

        public override string ToString()
        {
            return $"OrderItemId: {OrderItemId}, Quantity: {Quantity}, OrderId: {OrderId}, MenuItemId: {MenuItemId}";
        }
    }
}
