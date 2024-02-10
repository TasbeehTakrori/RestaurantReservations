using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Application.Migrations
{
    public partial class UpdateEmployeePositionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Myrna_Hansen@hotmail.com", "Al", "Carter", "(297) 403-8048" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Russel44@yahoo.com", "Santina", "Deckow", "(595) 314-3206" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Ida_Ledner6@hotmail.com", "Marlee", "Wiegand", "208-991-8033 x697" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Rahsaan_Marks@gmail.com", "Jean", "Altenwerth", "1-848-883-9492 x9300" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Camryn_Jenkins75@gmail.com", "Georgette", "Dach", "482-367-7930 x6290" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Mathew.Schmitt80@gmail.com", "Eryn", "Haley", "(611) 215-1265" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Anissa_Bode@gmail.com", "Florida", "Kessler", "463.522.0185 x023" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Lexi43@yahoo.com", "Mervin", "Mayer", "1-449-257-1523 x428" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Janie_Batz@hotmail.com", "Bernardo", "Murray", "915-847-1249 x474" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Karen76@yahoo.com", "Twila", "Cummerata", "726-372-2289 x791" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Darrel", "McCullough", 0, 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Angelo", "Klein", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Position" },
                values: new object[] { "Jeannie", "Mills", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Rafael", "Hamill", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Steven", "Johnson", 4, 5 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Marion", "Swift", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Kristy", "Blanda", 1, 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Ut id in et aut quo eos.", "Practical Granite Chair", 84.90m, 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Quis illo et inventore nemo officia et aut recusandae.", "Unbranded Granite Soap", 90.16m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Porro officia aut consequuntur placeat quod temporibus voluptatem culpa fugiat.", "Unbranded Plastic Pants", 62.00m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Et provident sunt pariatur nihil.", "Practical Steel Shirt", 57.48m, 1 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Perspiciatis excepturi architecto vel eaque est.", "Intelligent Soft Hat", 87.91m, 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Vitae error illo ut et.", "Tasty Concrete Shoes", 60.55m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Eaque commodi quia.", "Awesome Plastic Cheese", 41.41m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Odio rerum qui et sit.", "Licensed Rubber Ball", 33.14m, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Non minus quam aspernatur iste reprehenderit voluptatem culpa.", "Tasty Soft Tuna", 74.44m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Aut consequuntur nihil in animi quia.", "Refined Frozen Keyboard", 31.47m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 8, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 10, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 8, 9, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 6, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 8,
                columns: new[] { "OrderId", "Quantity" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 9,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 10,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 11,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 5, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 12,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 1, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 13,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 3, 6, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 14,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 10, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 15,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 16,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 17,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 10, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 18,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 19,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 20,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 7, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 4, new DateTime(2024, 2, 10, 4, 30, 36, 942, DateTimeKind.Local).AddTicks(4652), 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 6, new DateTime(2024, 2, 10, 0, 59, 31, 477, DateTimeKind.Local).AddTicks(4214), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 3, new DateTime(2024, 2, 10, 8, 36, 38, 836, DateTimeKind.Local).AddTicks(7392), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 2, new DateTime(2024, 2, 10, 4, 49, 21, 95, DateTimeKind.Local).AddTicks(5736), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 2, new DateTime(2024, 2, 9, 23, 28, 35, 327, DateTimeKind.Local).AddTicks(4572), 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 1, new DateTime(2024, 2, 10, 10, 3, 29, 241, DateTimeKind.Local).AddTicks(406), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 3, new DateTime(2024, 2, 9, 19, 47, 20, 614, DateTimeKind.Local).AddTicks(2893), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 2, 9, 21, 46, 53, 73, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 7, new DateTime(2024, 2, 9, 15, 43, 1, 2, DateTimeKind.Local).AddTicks(468), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 1, new DateTime(2024, 2, 10, 14, 43, 13, 513, DateTimeKind.Local).AddTicks(1183), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 3, 15, new DateTime(2024, 4, 26, 15, 7, 2, 900, DateTimeKind.Local).AddTicks(9828), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 7, 17, new DateTime(2024, 2, 23, 23, 33, 8, 576, DateTimeKind.Local).AddTicks(251), 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 4, 16, new DateTime(2024, 6, 8, 13, 14, 26, 164, DateTimeKind.Local).AddTicks(5590), 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId" },
                values: new object[] { 7, 2, new DateTime(2024, 6, 20, 16, 36, 3, 33, DateTimeKind.Local).AddTicks(1110), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 9, 9, new DateTime(2024, 6, 10, 22, 27, 14, 513, DateTimeKind.Local).AddTicks(5974), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 4, 15, new DateTime(2024, 6, 25, 16, 45, 59, 823, DateTimeKind.Local).AddTicks(207), 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 1, 11, new DateTime(2024, 8, 20, 14, 20, 2, 374, DateTimeKind.Local).AddTicks(6884), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 2, 18, new DateTime(2025, 1, 24, 3, 3, 55, 572, DateTimeKind.Local).AddTicks(3648), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 9, 17, new DateTime(2024, 2, 11, 11, 56, 21, 11, DateTimeKind.Local).AddTicks(6593), 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 1, 11, new DateTime(2025, 1, 16, 2, 26, 46, 496, DateTimeKind.Local).AddTicks(4348), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber" },
                values: new object[] { "8221 Jakob Forks, East Arvelside, China", new TimeOnly(21, 0, 0), "Waters, Kuhn and Langworth", "849.543.8814" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "007 Witting Forges, Lake Jovaniville, Bhutan", new TimeOnly(22, 0, 0), "Zieme - Hammes", "(272) 876-9546 x275", new TimeOnly(7, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "911 Freddie Overpass, Goldnertown, Denmark", new TimeOnly(21, 0, 0), "Stroman, McDermott and Heaney", "457-441-4234", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "5890 Melvin Court, Wilbertport, Libyan Arab Jamahiriya", new TimeOnly(22, 0, 0), "Kessler, Greenholt and Schultz", "378-874-6693", new TimeOnly(8, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "3083 Clement Spurs, Kailynmouth, Martinique", new TimeOnly(22, 0, 0), "O'Connell - Goodwin", "517-794-8743", new TimeOnly(8, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "RestaurantId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8,
                column: "RestaurantId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9,
                column: "Capacity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11,
                column: "RestaurantId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 14,
                column: "Capacity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 15,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 16,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 17,
                column: "Capacity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 18,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 19,
                column: "Capacity",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 20,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Madilyn_Howe@gmail.com", "Noel", "O'Kon", "277-628-9598 x943" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Merl89@gmail.com", "Zelma", "Koss", "342-491-5927 x42627" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Deontae83@gmail.com", "Charlene", "Parker", "625.248.0512 x1382" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Jamey.Windler@hotmail.com", "Russell", "Blick", "(901) 405-3625 x62300" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Hellen41@yahoo.com", "Wallace", "Brakus", "1-583-453-0987" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Hildegard.Schneider@gmail.com", "Edison", "Cruickshank", "(540) 356-7963 x215" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Joshua47@yahoo.com", "Camylle", "Nader", "(883) 309-3715 x47699" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Jeromy_Sauer10@yahoo.com", "Bernardo", "Veum", "(382) 219-4086" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Marcelino_Rippin@gmail.com", "Euna", "Ebert", "846-243-4823" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Maud_Prohaska5@gmail.com", "Whitney", "Flatley", "840.617.7224 x95109" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Suzanne", "Deckow", "Human Web Designer", 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Sylvia", "Rice", "Senior Data Officer", 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Position" },
                values: new object[] { "Kristen", "Hessel", "Principal Quality Executive" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Joanna", "Feeney", "Dynamic Optimization Supervisor", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Robyn", "Beer", "Corporate Marketing Planner", 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Bert", "Balistreri", "Future Accounts Agent", 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[] { "Gladys", "Watsica", "Dynamic Marketing Engineer", 4 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Consectetur quis perferendis distinctio voluptatibus modi tempora eum laborum.", "Practical Frozen Mouse", 95.43m, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Facere nulla ut est ipsum vel praesentium hic voluptatibus maiores.", "Tasty Plastic Chicken", 30.69m, 4 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Blanditiis rerum qui autem et necessitatibus quis.", "Ergonomic Frozen Keyboard", 63.66m, 3 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Eaque nam est sint.", "Ergonomic Rubber Car", 96.13m, 2 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Ipsum quas voluptas temporibus ab sint.", "Rustic Steel Ball", 80.43m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Non dolorem sed.", "Fantastic Granite Table", 57.82m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Est accusamus vel ipsum autem excepturi aut laudantium molestiae repellat.", "Refined Granite Gloves", 18.12m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Laudantium fuga ipsam magnam aut.", "Refined Fresh Chicken", 32.60m, 5 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Et sint modi sit.", "Small Soft Ball", 45.92m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "RestaurantId" },
                values: new object[] { "Amet non qui voluptate incidunt.", "Unbranded Frozen Chair", 63.62m, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 8, 5, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 6, 8, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 5, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 5, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7,
                columns: new[] { "MenuItemId", "OrderId" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 8,
                columns: new[] { "OrderId", "Quantity" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 9,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 10,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 5, 5, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 11,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 9, 8, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 12,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 4, 10, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 13,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 9, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 14,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 2, 6, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 15,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 5, 7, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 16,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 6, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 17,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 8, 4, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 18,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 19,
                columns: new[] { "MenuItemId", "Quantity" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 20,
                columns: new[] { "MenuItemId", "OrderId", "Quantity" },
                values: new object[] { 3, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 8, 8, 6, 466, DateTimeKind.Local).AddTicks(1562), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 5, new DateTime(2023, 12, 31, 3, 26, 37, 444, DateTimeKind.Local).AddTicks(8643), 8 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 2, new DateTime(2023, 12, 30, 15, 12, 47, 631, DateTimeKind.Local).AddTicks(3940), 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 3, new DateTime(2023, 12, 30, 13, 10, 16, 118, DateTimeKind.Local).AddTicks(2406), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 5, new DateTime(2023, 12, 30, 17, 54, 50, 538, DateTimeKind.Local).AddTicks(6985), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 3, new DateTime(2023, 12, 31, 4, 9, 4, 588, DateTimeKind.Local).AddTicks(4142), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 5, new DateTime(2023, 12, 30, 16, 42, 39, 479, DateTimeKind.Local).AddTicks(4436), 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 14, 56, 38, 726, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 4, new DateTime(2023, 12, 30, 19, 15, 50, 139, DateTimeKind.Local).AddTicks(1746), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[] { 5, new DateTime(2023, 12, 31, 10, 34, 46, 223, DateTimeKind.Local).AddTicks(6785), 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 8, 1, new DateTime(2024, 6, 23, 7, 5, 3, 241, DateTimeKind.Local).AddTicks(4571), 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 6, 3, new DateTime(2024, 7, 20, 2, 19, 13, 274, DateTimeKind.Local).AddTicks(4292), 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 1, 3, new DateTime(2024, 5, 15, 14, 47, 2, 859, DateTimeKind.Local).AddTicks(6590), 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId" },
                values: new object[] { 2, 3, new DateTime(2024, 6, 30, 13, 44, 11, 983, DateTimeKind.Local).AddTicks(4366), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 4, 2, new DateTime(2024, 4, 24, 1, 54, 26, 951, DateTimeKind.Local).AddTicks(3680), 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 8, 2, new DateTime(2024, 11, 7, 8, 35, 59, 707, DateTimeKind.Local).AddTicks(5875), 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 25, 10, 55, 31, 390, DateTimeKind.Local).AddTicks(7451), 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 1, 1, new DateTime(2024, 8, 23, 17, 1, 58, 665, DateTimeKind.Local).AddTicks(3939), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "TableId" },
                values: new object[] { 8, 2, new DateTime(2024, 11, 30, 21, 47, 43, 25, DateTimeKind.Local).AddTicks(7024), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[] { 2, 3, new DateTime(2024, 5, 17, 0, 35, 4, 528, DateTimeKind.Local).AddTicks(5136), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber" },
                values: new object[] { "45937 Rath Lights, North Pink, Falkland Islands (Malvinas)", new TimeOnly(20, 0, 0), "Larson - Fadel", "1-871-906-6169 x054" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "656 Schneider Park, West Afton, Denmark", new TimeOnly(19, 0, 0), "Stoltenberg - Gorczany", "882.245.3043", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "24862 Herzog Mills, Shemarmouth, Russian Federation", new TimeOnly(20, 0, 0), "Strosin Group", "233-917-9228 x642", new TimeOnly(7, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "20391 Antone Flats, Lake Armani, Nepal", new TimeOnly(18, 0, 0), "Harris - Abshire", "(567) 248-4320", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[] { "660 Bednar Port, East Anibalside, Myanmar", new TimeOnly(20, 0, 0), "Mueller, Reichel and Walker", "931-700-2601", new TimeOnly(6, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "RestaurantId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8,
                column: "RestaurantId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9,
                column: "Capacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11,
                column: "RestaurantId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 14,
                column: "Capacity",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 15,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 16,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 17,
                column: "Capacity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 18,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 19,
                column: "Capacity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 20,
                columns: new[] { "Capacity", "RestaurantId" },
                values: new object[] { 2, 5 });
        }
    }
}
