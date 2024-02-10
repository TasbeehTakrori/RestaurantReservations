using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.ViewModels
{
    public class OrderWithMenuItemsVM
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<MenuItemDTO> MenuItems { get; set; }
    }
}
