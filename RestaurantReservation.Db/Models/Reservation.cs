using RestaurantReservation.Db.Enums;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class Reservation
    {
        public Reservation()
        {
            Orders = new List<Order>();
        }

        [Key]
        public int ReservationId { get; init; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public PartySize PartySize { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public int TableId { get; set; }

        public Table Table { get; set; }

        public ICollection<Order> Orders { get; set; }

        [Required]
        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
