using EntityFrameworkCore.Projectables;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; init; }

        [MaxLength(255)]
        public string Name { get; set; }

        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        [Projectable]
        public string OpeningHours => $"{StartTime} - {EndTime}";

        public ICollection<Table> Tables { get; set; } = new List<Table>();

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }
}
