namespace RestaurantReservation.Domain.DTOs
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

        public override string ToString()
        {
            return $" - ReservationId: {ReservationId}, ReservationDate: {ReservationDate}, PartySize: {PartySize}, " +
                   $"CustomerId: {CustomerId}, FirstName: {FirstName}, LastName: {LastName}, " +
                   $"CustomerPhoneNumber: {CustomerPhoneNumber}, RestaurantId: {RestaurantId}, " +
                   $"RestaurantName: {RestaurantName}, RestaurantPhoneNumber: {RestaurantPhoneNumber}";
        }
    }
}
