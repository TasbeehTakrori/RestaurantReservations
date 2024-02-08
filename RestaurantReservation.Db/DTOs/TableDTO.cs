namespace RestaurantReservation.Domain.DTOs
{
    public class TableDTO
    {
        public int TableId { get; set; }
        public int Capacity { get; set; }
        public int RestaurantId { get; set; }

        public override string ToString()
        {
            return $"TableId: {TableId}, Capacity: {Capacity}, RestaurantId: {RestaurantId}";
        }
    }
}
