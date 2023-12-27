using EntityFrameworkCore.Projectables;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, MaxLength(255)]
        public string FirstName { get; set; }

        [Required, MaxLength(255)]
        public string LastName { get; set; }

        public string Position { get; set; }

        [Required]
        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        [Projectable]
        public string FullName => FirstName + " " + LastName;
    }
}
