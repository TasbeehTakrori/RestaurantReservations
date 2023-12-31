using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    public partial class AddReservationsDetailsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                CREATE VIEW ReservationsDetailsView AS
                SELECT
                    Reservations.ReservationId,
                    Reservations.ReservationDate,
                    Reservations.PartySize,
                    Customers.CustomerId,
                    Customers.FirstName,
                    Customers.LastName,
                    Customers.PhoneNumber AS CustomerPhoneNumber,
                    Restaurants.RestaurantId,
                    Restaurants.Name AS RestaurantName,
                    Restaurants.PhoneNumber AS RestaurantPhoneNumber FROM Reservations 
                INNER JOIN Customers ON Customers.CustomerId = Reservations.CustomerId
                INNER JOIN Restaurants ON Reservations.RestaurantId = Restaurants.RestaurantId;
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DROP VIEW ReservationsDetailsView;");
        }
    }
}
