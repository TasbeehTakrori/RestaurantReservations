namespace RestaurantReservation.Application.Models
{
        public class EmployeesWithRestaurantDetailsDTO
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int RestaurantId { get; set; }
            public string RestaurantName { get; set; }
            public string RestaurantAddress { get; set; }
            public string RestaurantPhoneNumber { get; set; }
        }
}
