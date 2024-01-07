namespace RestaurantReservation.Db.DTOs
{
    namespace RestaurantReservation.Db.Entities
    {
        public class EmployeesWithRestaurantDetailsViewDTO
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int RestaurantId { get; set; }
            public string RestaurantName { get; set; }
            public string RestaurantAddress { get; set; }
            public string RestaurantPhoneNumber { get; set; }
            public override string ToString()
            {
                return $" - EmployeeId: {EmployeeId}, FirstName: {FirstName}, LastName: {LastName}, " +
                       $"RestaurantId: {RestaurantId}, RestaurantName: {RestaurantName}, " +
                       $"RestaurantAddress: {RestaurantAddress}, RestaurantPhoneNumber: {RestaurantPhoneNumber}";
            }
        }
    }
}
