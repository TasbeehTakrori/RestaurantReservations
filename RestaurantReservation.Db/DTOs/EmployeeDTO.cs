namespace RestaurantReservation.Db.DTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int RestaurantId { get; set; }

        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId}, FirstName: {FirstName}, LastName: {LastName}, Position: {Position}, RestaurantId: {RestaurantId}";
        }
    }
}
