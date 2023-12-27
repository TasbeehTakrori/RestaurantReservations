using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class Table
    {
        [Key]
        public int TableId { get; init; }

        [Required]
        public int Capacity { get; init; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        [Required]
        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
