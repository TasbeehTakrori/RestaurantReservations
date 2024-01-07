using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    public partial class AddEmployeesWithRestaurantDetailsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                CREATE OR ALTER VIEW EmployeesWithRestaurantDetailsView AS
                SELECT
                    Employees.EmployeeId,
                    Employees.FirstName,
                    Employees.LastName,
                    Restaurants.RestaurantId,
                    Restaurants.Name AS RestaurantName,
                    Restaurants.Address AS RestaurantAddress,
                    Restaurants.PhoneNumber AS RestaurantPhoneNumber
                FROM
                    Employees
                INNER JOIN
                    Restaurants ON Employees.RestaurantId = Restaurants.RestaurantId;
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DROP VIEW EmployeesWithRestaurantDetailsView;");
        }
    }
}
