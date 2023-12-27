using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservation.Db.Models
{
    internal class Restaurant
    {
        [Key]
        public int RestaurantId { get; init; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public WorkingHours OpeningHours { get; set; }

        public ICollection<Table> Tables { get; set; } = new List<Table>();

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }
}
