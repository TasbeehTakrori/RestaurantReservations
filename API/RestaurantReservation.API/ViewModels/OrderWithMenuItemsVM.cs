using RestaurantReservation.Application.DTOs;
using System;
using System.Collections.Generic;

namespace RestaurantReservation.API.ViewModels
{
    /// <summary>
    /// View model for representing an order along with its associated menu items.
    /// </summary>
    public class OrderWithMenuItemsVM
    {
        /// <summary>
        /// The unique identifier of the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// The date and time when the order was placed.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// The list of menu items included in the order.
        /// </summary>
        public List<MenuItemDTO> MenuItems { get; set; }
    }
}
