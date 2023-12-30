namespace RestaurantReservation.Db.DTOs
{
    public class RestaurantDTO
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string OpeningHours { get; set; }

        public override string ToString()
        {
            return $"RestaurantId: {RestaurantId}, Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, StartTime: {StartTime}, EndTime: {EndTime}, OpeningHours: {OpeningHours}";
        }
    }
}
