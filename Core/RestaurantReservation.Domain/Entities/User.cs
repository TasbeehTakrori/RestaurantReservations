namespace RestaurantReservation.Domain.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }
    }
}
