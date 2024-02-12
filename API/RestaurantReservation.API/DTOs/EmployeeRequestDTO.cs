namespace RestaurantReservation.API.DTOs
{
    /// <summary>
    /// Data transfer object for creating or updating an employee.
    /// </summary>
    public class EmployeeRequestDTO
    {
        /// <summary>
        /// First name of the employee.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the employee.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Position of the employee.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// ID of the restaurant to which the employee belongs.
        /// </summary>
        public int RestaurantId { get; set; }
    }
}
