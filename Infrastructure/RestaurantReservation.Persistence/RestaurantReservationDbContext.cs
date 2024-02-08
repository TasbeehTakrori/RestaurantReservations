using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Domain
{
    public class RestaurantReservationDbContext : DbContext
    {
        private readonly DbContextOptions _dbContextOptions;

        public RestaurantReservationDbContext(IOptions<DbContextOptions> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions.Value;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<ReservationsDetails> ReservationsDetails { get; set; }
        public DbSet<EmployeesWithRestaurantDetails> EmployeesWithRestaurantDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _dbContextOptions.ConnectionString;
            optionsBuilder.UseSqlServer(connectionString,
                x => x.UseDateOnlyTimeOnly()).LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDbFunction(typeof(RestaurantReservationDbContext)
                .GetMethod(nameof(CalculateTotalRevenue), new[] { typeof(int) }))
                .HasName("CalculateTotalRevenue");

            modelBuilder.Entity<ReservationsDetails>()
                .HasNoKey()
                .ToView(nameof(ReservationsDetails));

            modelBuilder.Entity<EmployeesWithRestaurantDetails>()
               .HasNoKey()
               .ToView(nameof(EmployeesWithRestaurantDetails));

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Table)
                .WithMany(t => t.Reservations)
                .HasForeignKey(r => r.TableId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Reservation>()
                .HasMany(r => r.Orders)
                .WithOne(t => t.Reservation)
                .HasForeignKey(r => r.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderItem>()
                 .HasOne(oi => oi.Order)
                 .WithMany(o => o.OrderItems)
                 .HasForeignKey(oi => oi.OrderId)
                 .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

            DbSeeder.SeedCustomersTable(modelBuilder);
            DbSeeder.SeedEmployeeTable(modelBuilder);
            DbSeeder.SeedMenuItemsTable(modelBuilder);
            DbSeeder.SeedOrdersTable(modelBuilder);
            DbSeeder.SeedOrderItemsTable(modelBuilder);
            DbSeeder.SeedReservationsTable(modelBuilder);
            DbSeeder.SeedRestaurantsTable(modelBuilder);
            DbSeeder.SeedTablesTable(modelBuilder);
        }
        public decimal CalculateTotalRevenue(int restaurantId)
            => throw new NotSupportedException();
    }
}
