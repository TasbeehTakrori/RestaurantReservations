using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Domain.Migrations
{
    public partial class UpdateCustomerEmailToBeUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Dalton99@hotmail.com", "Russell", "Wehner", "1-316-948-8692" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Allan_Nikolaus74@yahoo.com", "Furman", "Schneider", "(282) 228-7701 x28624" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Katlynn_Strosin47@hotmail.com", "Briana", "Bruen", "686.904.7558" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Felipe28@yahoo.com", "Linnea", "Reynolds", "464.365.6416" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Merlin.Bergnaum99@yahoo.com", "Berniece", "Considine", "(705) 810-0208" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Kaci76@gmail.com", "Nicolas", "Rutherford", "(478) 831-1386" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Astrid.Feeney37@yahoo.com", "Marie", "Becker", "(265) 878-3667" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Raquel.Kshlerin5@yahoo.com", "Effie", "Bartell", "1-227-238-4018 x3791" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Josue96@yahoo.com", "Lonie", "Grimes", "1-904-294-0698" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Helen89@hotmail.com", "Graham", "Mayert", "(644) 437-3815" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Randy", "Ondricka", "Lead Implementation Associate", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Mercedes", "Wintheiser", "Legacy Infrastructure Strategist", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Position" },
                values: new object[] { "Nathan", "Dickens", "International Research Liaison" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Francis", "Moore", "Global Tactics Designer", 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Shawna", "Hayes", "Chief Intranet Architect", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Norman", "Kris", "Principal Communications Designer", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Whitney", "Johnston", "Regional Operations Representative", 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Saepe atque delectus voluptas et.", "Incredible Frozen Table", 86.78m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Dolores explicabo voluptatem.", "Refined Metal Shirt", 74.27m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Necessitatibus qui voluptatem quasi consequatur corporis.", "Awesome Plastic Keyboard", 71.51m, 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Dolore incidunt atque consectetur odit reprehenderit.", "Generic Rubber Fish", 78.11m, 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Sapiente molestiae sint recusandae sed in delectus maiores.", "Sleek Metal Bike", 57.48m, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et eum expedita voluptatem et odio voluptatibus nulla ipsum laborum.", "Licensed Granite Bike", 51.93m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Laboriosam quod itaque aliquid.", "Tasty Metal Fish", 88.83m, 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Alias quo voluptatem aut dolores fuga beatae praesentium dolor nihil.", "Awesome Concrete Salad", 35.62m, 2 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Asperiores eum vitae.", "Licensed Frozen Cheese", 27.45m, 2 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Molestias dolorem voluptatum rerum et.", "Small Concrete Shirt", 10.08m, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                columns: new[] { "OrderId", "Quantity" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 3, 9, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                columns: new[] { "OrderId", "Quantity" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 9, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 4, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 8,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 9, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 9,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 8, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 10,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 8, 4, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 11,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 8, 4, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 12,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 13,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 14,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 1, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 15,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 6, 8, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 16,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 17,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 6, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 18,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 19,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 4, 6, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 20,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 4, new DateTime(2023, 12, 28, 23, 1, 53, 72, DateTimeKind.Local).AddTicks(7688), 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 4, new DateTime(2023, 12, 29, 5, 30, 34, 653, DateTimeKind.Local).AddTicks(4989), 8 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 6, new DateTime(2023, 12, 29, 1, 24, 33, 36, DateTimeKind.Local).AddTicks(2974), 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 7, new DateTime(2023, 12, 29, 5, 14, 44, 325, DateTimeKind.Local).AddTicks(9098), 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 28, 15, 47, 33, 841, DateTimeKind.Local).AddTicks(724), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "EmployeeId", "OrderDate" },
                values: new object[] { 6, new DateTime(2023, 12, 28, 16, 45, 54, 583, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 28, 17, 26, 4, 930, DateTimeKind.Local).AddTicks(4434), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 2, new DateTime(2023, 12, 29, 7, 59, 34, 633, DateTimeKind.Local).AddTicks(5603), 8 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 29, 3, 39, 16, 698, DateTimeKind.Local).AddTicks(6180), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 29, 5, 25, 32, 718, DateTimeKind.Local).AddTicks(1195), 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 8, 2, new DateTime(2024, 10, 14, 8, 6, 8, 216, DateTimeKind.Local).AddTicks(4940), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId" },
                values: new object[] { 4, 1, new DateTime(2024, 3, 20, 22, 20, 58, 597, DateTimeKind.Local).AddTicks(1765), 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 5, 2, new DateTime(2024, 7, 3, 4, 37, 30, 966, DateTimeKind.Local).AddTicks(841), 5, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 3, 1, new DateTime(2024, 12, 20, 17, 33, 51, 773, DateTimeKind.Local).AddTicks(7059), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 9, 1, new DateTime(2024, 1, 16, 17, 41, 5, 61, DateTimeKind.Local).AddTicks(9292), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 4, 1, new DateTime(2024, 6, 5, 19, 42, 59, 490, DateTimeKind.Local).AddTicks(3556), 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 2, 1, new DateTime(2024, 11, 24, 5, 49, 9, 435, DateTimeKind.Local).AddTicks(8012), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 4, 2, new DateTime(2024, 6, 10, 14, 19, 21, 97, DateTimeKind.Local).AddTicks(833), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 5, 3, new DateTime(2024, 11, 19, 22, 42, 3, 174, DateTimeKind.Local).AddTicks(3164), 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "CustomerId", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 1, new DateTime(2024, 8, 24, 4, 22, 48, 243, DateTimeKind.Local).AddTicks(8043), 4, 8 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "86999 Waters Road, Schoenfort, Tunisia", new TimeOnly(18, 0, 0), "Schroeder Inc", "440.718.3975 x17355", new TimeOnly(7, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "0353 Scotty Divide, East Dejonview, Tajikistan", new TimeOnly(22, 0, 0), "Feest Inc", "(834) 509-2851", new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "25606 Runte Divide, Lake Clyde, Ghana", new TimeOnly(22, 0, 0), "Dibbert LLC", "634-270-4788", new TimeOnly(7, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "47516 Rhoda Mall, North Letitia, Guinea-Bissau", new TimeOnly(18, 0, 0), "Kerluke Inc", "1-346-220-8025 x7451", new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "842 Stefanie Courts, Wintheiserstad, San Marino", new TimeOnly(18, 0, 0), "Gerhold and Sons", "(752) 533-5199 x52895", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "Capacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5,
                column: "RestaurantId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7,
                column: "RestaurantId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10,
                column: "Capacity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 14,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 15,
                column: "Capacity",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 16,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 17,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 18,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 19,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 20,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Asa_Bartell@yahoo.com", "Moshe", "Wisoky", "1-652-732-3001 x851" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Enola.Runolfsdottir54@yahoo.com", "Loraine", "Predovic", "(682) 289-7697 x06683" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Arnaldo_Rutherford@yahoo.com", "Lori", "MacGyver", "739.360.4252" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Mckayla.Bins66@yahoo.com", "Keely", "Hagenes", "422-276-9201 x024" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Saul_Mitchell74@yahoo.com", "Sister", "Kling", "1-887-318-3343 x973" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Kendrick60@hotmail.com", "Abelardo", "Collier", "1-940-768-4873 x0005" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Tomasa_DAmore79@gmail.com", "Anya", "Tromp", "(488) 917-5617 x151" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Audrey.Kutch61@hotmail.com", "Aniya", "Glover", "(380) 916-6502 x54015" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Alia.Corkery@gmail.com", "Hank", "Trantow", "430.467.0597 x85572" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Rosanna.Hintz37@hotmail.com", "Brooklyn", "Lynch", "306.418.8869" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Megan", "Reinger", "Regional Program Engineer", 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Gladys", "Breitenberg", "Senior Assurance Agent", 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Position" },
                values: new object[] { "Rosemary", "Daugherty", "Chief Accounts Coordinator" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Mable", "Lesch", "Direct Web Orchestrator", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Sara", "Rippin", "Regional Quality Supervisor", 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Greg", "Koss", "Principal Accounts Technician", 5 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Diane", "Bernier", "Regional Solutions Consultant", 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Dolore ut porro ut.", "Ergonomic Plastic Salad", 15.33m, 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Assumenda quo et.", "Practical Frozen Pants", 56.42m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Molestiae aut fugit minima dolores.", "Rustic Plastic Bacon", 38.80m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Reprehenderit ullam accusantium quas illo fuga voluptatem impedit.", "Sleek Cotton Ball", 64.72m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Repellendus molestiae aut est repellat omnis ut quisquam.", "Fantastic Frozen Tuna", 97.64m, 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Facere eligendi aliquid.", "Tasty Cotton Ball", 97.47m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Voluptas omnis hic atque omnis.", "Unbranded Fresh Chair", 77.86m, 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Sapiente dolorum eveniet necessitatibus quasi et nihil facilis atque.", "Licensed Wooden Table", 62.40m, 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "In dolor nisi rerum.", "Rustic Plastic Soap", 97.83m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Excepturi voluptas consectetur illum qui.", "Awesome Rubber Chips", 80.59m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 6, 7, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                columns: new[] { "OrderId", "Quantity" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 2, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                columns: new[] { "OrderId", "Quantity" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 8, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 4, 5, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 8,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 9,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 6, 5, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 10,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 5, 6, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 11,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 12,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 13,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 14,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 15,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 16,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 17,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 6, 9, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 18,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 10, 7 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 19,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 10, 5, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 20,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 7, new DateTime(2023, 12, 27, 16, 46, 18, 409, DateTimeKind.Local).AddTicks(8229), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 14, 51, 42, 377, DateTimeKind.Local).AddTicks(5486), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 3, new DateTime(2023, 12, 27, 9, 28, 50, 725, DateTimeKind.Local).AddTicks(1856), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 6, new DateTime(2023, 12, 27, 17, 24, 19, 567, DateTimeKind.Local).AddTicks(2936), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 27, 13, 51, 18, 451, DateTimeKind.Local).AddTicks(5550), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "EmployeeId", "OrderDate" },
                values: new object[] { 4, new DateTime(2023, 12, 27, 15, 29, 36, 364, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 27, 13, 31, 46, 762, DateTimeKind.Local).AddTicks(4958), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 6, new DateTime(2023, 12, 27, 16, 23, 14, 526, DateTimeKind.Local).AddTicks(6457), 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 27, 3, 17, 57, 659, DateTimeKind.Local).AddTicks(5029), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "OrderDate", "ReservationId" },
                values: new object[] { new DateTime(2023, 12, 27, 3, 28, 23, 519, DateTimeKind.Local).AddTicks(7504), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 7, 3, new DateTime(2024, 1, 22, 10, 3, 2, 711, DateTimeKind.Local).AddTicks(5425), 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId" },
                values: new object[] { 9, 3, new DateTime(2024, 5, 25, 20, 4, 36, 571, DateTimeKind.Local).AddTicks(104), 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 8, 3, new DateTime(2024, 5, 6, 18, 13, 35, 955, DateTimeKind.Local).AddTicks(7257), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 6, 2, new DateTime(2024, 9, 19, 15, 45, 52, 972, DateTimeKind.Local).AddTicks(5905), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 4, 3, new DateTime(2024, 9, 21, 0, 12, 52, 501, DateTimeKind.Local).AddTicks(3174), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 1, 3, new DateTime(2024, 10, 11, 21, 45, 2, 591, DateTimeKind.Local).AddTicks(6752), 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 1, 3, new DateTime(2024, 11, 28, 9, 31, 49, 719, DateTimeKind.Local).AddTicks(6055), 1, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 8, 1, new DateTime(2024, 4, 6, 0, 35, 29, 486, DateTimeKind.Local).AddTicks(1394), 5, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 8, 1, new DateTime(2024, 4, 1, 12, 24, 54, 777, DateTimeKind.Local).AddTicks(3867), 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "CustomerId", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 10, new DateTime(2024, 2, 7, 7, 48, 28, 70, DateTimeKind.Local).AddTicks(6795), 1, 6 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "702 Homenick Flat, Larissahaven, Bhutan", new TimeOnly(21, 0, 0), "King, Ferry and Schmeler", "334-483-1332 x568", new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "18336 Schaefer Estate, Durganshire, Puerto Rico", new TimeOnly(18, 0, 0), "Rice Group", "1-284-235-7793", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "2176 Virginia Knoll, South Aracelystad, Gabon", new TimeOnly(18, 0, 0), "Kassulke - Haley", "227.733.9483", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "11913 Macejkovic Corners, South Kellen, Egypt", new TimeOnly(21, 0, 0), "Powlowski LLC", "(219) 769-7389 x7293", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "8265 Kyra Fall, Carterburgh, Wallis and Futuna", new TimeOnly(20, 0, 0), "Will LLC", "(713) 690-9370", new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "Capacity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5,
                column: "RestaurantId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7,
                column: "RestaurantId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10,
                column: "Capacity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 14,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 15,
                column: "Capacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 16,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 17,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 18,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 19,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 20,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 4, 1 });
        }
    }
}
