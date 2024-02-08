using System.Text;

namespace RestaurantReservation.Domain.Models
{
    public class OrderWithMenuItemDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<MenuItemDTO> MenuItems { get; set; }
    }
}
