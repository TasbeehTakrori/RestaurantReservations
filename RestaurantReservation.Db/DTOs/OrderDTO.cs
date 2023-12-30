namespace RestaurantReservation.Db.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ReservationId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalAmount { get; set; }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, OrderDate: {OrderDate}, ReservationId: {ReservationId}, EmployeeId: {EmployeeId}, TotalAmount: {TotalAmount}";
        }
    }
}
