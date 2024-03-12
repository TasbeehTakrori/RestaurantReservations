using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Application.DTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public EmployeePosition Position { get; set; }
        public int RestaurantId { get; set; }
    }
}
