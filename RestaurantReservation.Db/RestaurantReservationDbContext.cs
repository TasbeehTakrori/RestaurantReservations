using Microsoft.EntityFrameworkCore;


namespace RestaurantReservation.Db
{
    internal class RestaurantReservationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=RestaurantReservationCore;Integrated Security=True");
        }
    }
}
