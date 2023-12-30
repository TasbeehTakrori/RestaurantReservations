using EntityFrameworkCore.Projectables;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Entities
{
    public class Customer
    {
        public int CustomerId { get; init; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        [Projectable]
        public string FullName => FirstName + " " + LastName;
    }
}
