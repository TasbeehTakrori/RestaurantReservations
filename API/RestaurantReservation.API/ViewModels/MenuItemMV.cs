namespace RestaurantReservation.API.ViewModels
{
    /// <summary>
    /// View model for representing a menu item.
    /// </summary>
    public class MenuItemVM
    {
        /// <summary>
        /// The unique identifier of the menu item.
        /// </summary>
        public int MenuItemId { get; init; }

        /// <summary>
        /// The name of the menu item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the menu item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The price of the menu item.
        /// </summary>
        public decimal Price { get; set; }
    }
}
