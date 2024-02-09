
namespace RestaurantReservation.Application.Models
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ReservationId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }
    }
}
