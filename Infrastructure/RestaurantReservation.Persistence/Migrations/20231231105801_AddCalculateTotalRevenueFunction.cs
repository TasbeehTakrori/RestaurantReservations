using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Application.Migrations
{
    public partial class AddCalculateTotalRevenueFunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                CREATE OR ALTER FUNCTION CalculateTotalRevenue (@restaurantId INT)
                RETURNS DECIMAL(18, 2)
                AS
                BEGIN
                    DECLARE @totalRevenue DECIMAL(18, 2);

                    SELECT @totalRevenue = COALESCE(SUM(Price * Quantity), 0)
                    FROM Restaurants 
                    LEFT JOIN MenuItems ON Restaurants.RestaurantId = MenuItems.RestaurantId
                    LEFT JOIN OrderItems ON MenuItems.MenuItemId = OrderItems.MenuItemId
                    WHERE Restaurants.RestaurantId = @restaurantId

                    RETURN @totalRevenue;
                END;
                ");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DROP FUNCTION fn_CalculateTotalRevenue");
        }
    }
}
