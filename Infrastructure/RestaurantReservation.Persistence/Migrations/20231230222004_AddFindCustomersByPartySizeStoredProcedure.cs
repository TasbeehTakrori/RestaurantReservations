using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Application.Migrations
{
    public partial class AddFindCustomersByPartySizeStoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               @"CREATE OR ALTER PROCEDURE sp_FindCustomersByPartySize
                    @PartySize INT
                 AS
                 BEGIN
                    SELECT 
                        Customers.CustomerId,
		                FirstName,
		                LastName,
		                Email,
		                PhoneNumber
                    FROM
                        dbo.Customers
                    INNER JOIN 
                        dbo.Reservations
                    ON Customers.CustomerId = Reservations.CustomerId	
                    WHERE
                        Reservations.PartySize >= @PartySize;
                 END
               ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DROP PROCEDURE sp_FindCustomersByPartySize");
        }
    }
}
