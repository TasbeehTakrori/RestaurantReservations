using EntityFrameworkCore.Projectables;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db.Models
{
    internal class WorkingHours
    {
        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }

        [Projectable]
        public string OpeningHours => $"{StartTime} - {EndTime}";
    }
}
