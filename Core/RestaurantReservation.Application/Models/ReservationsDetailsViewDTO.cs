namespace RestaurantReservation.Domain.Models
{
    public class ReservationsDetailsViewDTO
    {
        public int ReservationId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int PartySize { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantPhoneNumber { get; set; }
    }
}
