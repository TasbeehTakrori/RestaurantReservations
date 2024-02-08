using RestaurantReservation.Domain.Entities;
using System.Text;

namespace RestaurantReservation.Domain.DTOs
{
    public class OrderWithMenuItemDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"OrderId: {OrderId}");
            stringBuilder.AppendLine($"OrderDate: {OrderDate}");
            stringBuilder.AppendLine($"TotalAmount: {TotalAmount}");

            if (MenuItems != null && MenuItems.Any())
            {
                stringBuilder.AppendLine("MenuItems:");
                foreach (var menuItem in MenuItems)
                {
                    stringBuilder.AppendLine($" - ID: {menuItem.MenuItemId}, Name: {menuItem.Name}");
                }
            }

            return stringBuilder.ToString();
        }
    }
}
