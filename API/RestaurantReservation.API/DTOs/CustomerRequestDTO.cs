namespace RestaurantReservation.API.DTOs
{
    /// <summary>
    /// Data transfer object for creating or updating a customer.
    /// </summary>
    public class CustomerRequestDTO
    {
        /// <summary>
        /// First name of the customer.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the customer.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of the customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone number of the customer.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
