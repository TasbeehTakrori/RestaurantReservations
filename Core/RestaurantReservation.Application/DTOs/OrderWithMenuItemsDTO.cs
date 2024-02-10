namespace RestaurantReservation.Application.DTOs
{
    public class OrderWithMenuItemsDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<MenuItemDTO> MenuItems { get; set; }
    }
}
