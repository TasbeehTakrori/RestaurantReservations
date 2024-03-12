using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.API.ViewModels
{
    /// <summary>
    /// View model for representing employee information.
    /// </summary>
    public class EmployeeVM
    {
        /// <summary>
        /// The unique identifier of the employee.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// The full name of the employee.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The position of the employee.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// The ID of the restaurant where the employee works.
        /// </summary>
        public int RestaurantId { get; set; }
    }
}
