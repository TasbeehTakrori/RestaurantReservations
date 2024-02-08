namespace RestaurantReservation.Domain.Models
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
    }
}
