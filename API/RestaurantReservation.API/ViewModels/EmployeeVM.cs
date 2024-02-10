using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.API.ViewModels
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public int RestaurantId { get; set; }
    }
}
