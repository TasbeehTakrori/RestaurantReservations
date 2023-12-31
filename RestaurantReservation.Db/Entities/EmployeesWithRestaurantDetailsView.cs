namespace RestaurantReservation.Db.Entities
{
    namespace RestaurantReservation.Db.Entities
    {
        public class EmployeesWithRestaurantDetailsView
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
}
