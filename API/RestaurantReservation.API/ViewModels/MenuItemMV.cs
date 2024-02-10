namespace RestaurantReservation.API.ViewModels
{
    public class MenuItemMV
    {
        public int MenuItemId { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
