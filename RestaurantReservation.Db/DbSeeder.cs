using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using Bogus;
using RestaurantReservation.Db.Enums;

namespace RestaurantReservation.Db
{
    internal static class DbSeeder
    {
        internal static void SeedCustomersTable(ModelBuilder modelBuilder)
        {
            int customerIdSequence = 1;

            var faker = new Faker<Customer>()
                .RuleFor(c => c.CustomerId, f => customerIdSequence++)
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber());

            var customers = faker.Generate(10);

            modelBuilder.Entity<Customer>().HasData(customers);
        }

        internal static void SeedRestaurantsTable(ModelBuilder modelBuilder)
        {
            int RestaurantIdSequence = 1;

            var faker = new Faker<Restaurant>()
                .RuleFor(r => r.RestaurantId, f => RestaurantIdSequence++)
                .RuleFor(r => r.Name, f => f.Company.CompanyName())
                .RuleFor(r => r.Address, f => f.Address.FullAddress())
                .RuleFor(r => r.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(r => r.StartTime, f => new TimeOnly(f.Random.Number(6, 10), 0))
                .RuleFor(r => r.EndTime, f => new TimeOnly(f.Random.Number(18, 22), 0));

            var restaurants = faker.Generate(5);

            modelBuilder.Entity<Restaurant>().HasData(restaurants);
        }

        internal static void SeedTablesTable(ModelBuilder modelBuilder)
        {
            int TableIdSequence = 1;

            var faker = new Faker<Table>()
                .RuleFor(t => t.TableId, f => TableIdSequence++)
                .RuleFor(t => t.Capacity, f => f.Random.Number(2, 8))
                .RuleFor(t => t.RestaurantId, f => f.Random.Number(1, 5));

            var tables = faker.Generate(20);

            modelBuilder.Entity<Table>().HasData(tables);
        }

        internal static void SeedEmployeeTable(ModelBuilder modelBuilder)
        {
            int EmployeeIdSequence = 1;

            var faker = new Faker<Employee>()
                .RuleFor(e => e.EmployeeId, f => EmployeeIdSequence++)
                .RuleFor(e => e.FirstName, f => f.Person.FirstName)
                .RuleFor(e => e.LastName, f => f.Person.LastName)
                .RuleFor(e => e.Position, f => f.Name.JobTitle())
                .RuleFor(e => e.RestaurantId, f => f.Random.Number(1, 5));

            var employees = faker.Generate(7);

            modelBuilder.Entity<Employee>().HasData(employees);
        }

        internal static void SeedMenuItemsTable(ModelBuilder modelBuilder)
        {
            int MenuItemIdSequence = 1;

            var faker = new Faker<MenuItem>()
                .RuleFor(mi => mi.MenuItemId, f => MenuItemIdSequence++)
                .RuleFor(mi => mi.Name, f => f.Commerce.ProductName())
                .RuleFor(mi => mi.Description, f => f.Lorem.Sentence())
                .RuleFor(mi => mi.Price, f => f.Finance.Amount(10, 100))
                .RuleFor(mi => mi.RestaurantId, f => f.Random.Number(1, 5));

            var menuItems = faker.Generate(10);

            modelBuilder.Entity<MenuItem>().HasData(menuItems);
        }

        internal static void SeedReservationsTable(ModelBuilder modelBuilder)
        {
            int ReservationIdSequence = 1;

            var faker = new Faker<Reservation>()
                .RuleFor(r => r.ReservationId, f => ReservationIdSequence++)
                .RuleFor(r => r.ReservationDate, f => f.Date.Future())
                .RuleFor(r => r.PartySize, f => f.PickRandom<PartySize>())
                .RuleFor(r => r.CustomerId, f => f.Random.Number(1, 10))
                .RuleFor(r => r.TableId, f => f.Random.Number(1, 10))
                .RuleFor(r => r.RestaurantId, f => f.Random.Number(1, 5));

            var reservations = faker.Generate(10);

            modelBuilder.Entity<Reservation>().HasData(reservations);
        }

        internal static void SeedOrdersTable(ModelBuilder modelBuilder)
        {
            int OrderIdSequence = 1;

            var faker = new Faker<Order>()
                .RuleFor(o => o.OrderId, f => OrderIdSequence++)
                .RuleFor(o => o.OrderDate, f => f.Date.Recent())
                .RuleFor(o => o.ReservationId, f => f.Random.Number(1, 10))
                .RuleFor(o => o.EmployeeId, f => f.Random.Number(1, 7));

            var orders = faker.Generate(10);

            modelBuilder.Entity<Order>().HasData(orders);
        }

        internal static void SeedOrderItemsTable(ModelBuilder modelBuilder)
        {
            int OrderItemIdSequence = 1;

            var faker = new Faker<OrderItem>()
                .RuleFor(oi => oi.OrderItemId, f => OrderItemIdSequence++)
                .RuleFor(oi => oi.Quantity, f => f.Random.Number(1, 5))
                .RuleFor(oi => oi.OrderId, f => f.Random.Number(1, 10))
                .RuleFor(oi => oi.MenuItemId, f => f.Random.Number(1, 10));

            var orderItems = faker.Generate(20);

            modelBuilder.Entity<OrderItem>().HasData(orderItems);
        }
    }
}
