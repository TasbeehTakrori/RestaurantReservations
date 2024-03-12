namespace RestaurantReservation.API.Controllers
{
    /// <summary>
    /// View model for representing customer information.
    /// </summary>
    public class CustomerVM
    {
        /// <summary>
        /// The unique identifier of the customer.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The full name of the customer.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the customer.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
