using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Application.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Asa_Bartell@yahoo.com", "Moshe", "Wisoky", "1-652-732-3001 x851" },
                    { 2, "Enola.Runolfsdottir54@yahoo.com", "Loraine", "Predovic", "(682) 289-7697 x06683" },
                    { 3, "Arnaldo_Rutherford@yahoo.com", "Lori", "MacGyver", "739.360.4252" },
                    { 4, "Mckayla.Bins66@yahoo.com", "Keely", "Hagenes", "422-276-9201 x024" },
                    { 5, "Saul_Mitchell74@yahoo.com", "Sister", "Kling", "1-887-318-3343 x973" },
                    { 6, "Kendrick60@hotmail.com", "Abelardo", "Collier", "1-940-768-4873 x0005" },
                    { 7, "Tomasa_DAmore79@gmail.com", "Anya", "Tromp", "(488) 917-5617 x151" },
                    { 8, "Audrey.Kutch61@hotmail.com", "Aniya", "Glover", "(380) 916-6502 x54015" },
                    { 9, "Alia.Corkery@gmail.com", "Hank", "Trantow", "430.467.0597 x85572" },
                    { 10, "Rosanna.Hintz37@hotmail.com", "Brooklyn", "Lynch", "306.418.8869" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "EndTime", "Name", "PhoneNumber", "StartTime" },
                values: new object[,]
                {
                    { 1, "702 Homenick Flat, Larissahaven, Bhutan", new TimeOnly(21, 0, 0), "King, Ferry and Schmeler", "334-483-1332 x568", new TimeOnly(10, 0, 0) },
                    { 2, "18336 Schaefer Estate, Durganshire, Puerto Rico", new TimeOnly(18, 0, 0), "Rice Group", "1-284-235-7793", new TimeOnly(6, 0, 0) },
                    { 3, "2176 Virginia Knoll, South Aracelystad, Gabon", new TimeOnly(18, 0, 0), "Kassulke - Haley", "227.733.9483", new TimeOnly(6, 0, 0) },
                    { 4, "11913 Macejkovic Corners, South Kellen, Egypt", new TimeOnly(21, 0, 0), "Powlowski LLC", "(219) 769-7389 x7293", new TimeOnly(6, 0, 0) },
                    { 5, "8265 Kyra Fall, Carterburgh, Wallis and Futuna", new TimeOnly(20, 0, 0), "Will LLC", "(713) 690-9370", new TimeOnly(9, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Megan", "Reinger", "Chef de Cuisine", 2 },
                    { 2, "Gladys", "Breitenberg", "Head Waiter", 4 },
                    { 3, "Rosemary", "Daugherty", "Manager", 5 },
                    { 4, "Mable", "Lesch", "Sous Chef", 1 },
                    { 5, "Sara", "Rippin", "Quality Control Specialist", 3 },
                    { 6, "Greg", "Koss", "Accounts Manager", 5 },
                    { 7, "Diane", "Bernier", "Customer Service Manager", 3 },
                    { 8, "John", "Doe", "Manager", 1 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "Description", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Dolore ut porro ut.", "Ergonomic Plastic Salad", 15.33m, 1 },
                    { 2, "Assumenda quo et.", "Practical Frozen Pants", 56.42m, 5 },
                    { 3, "Molestiae aut fugit minima dolores.", "Rustic Plastic Bacon", 38.80m, 5 },
                    { 4, "Reprehenderit ullam accusantium quas illo fuga voluptatem impedit.", "Sleek Cotton Ball", 64.72m, 5 },
                    { 5, "Repellendus molestiae aut est repellat omnis ut quisquam.", "Fantastic Frozen Tuna", 97.64m, 1 },
                    { 6, "Facere eligendi aliquid.", "Tasty Cotton Ball", 97.47m, 3 },
                    { 7, "Voluptas omnis hic atque omnis.", "Unbranded Fresh Chair", 77.86m, 1 },
                    { 8, "Sapiente dolorum eveniet necessitatibus quasi et nihil facilis atque.", "Licensed Wooden Table", 62.40m, 1 },
                    { 9, "In dolor nisi rerum.", "Rustic Plastic Soap", 97.83m, 5 },
                    { 10, "Excepturi voluptas consectetur illum qui.", "Awesome Rubber Chips", 80.59m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Capacity", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 7, 4 },
                    { 2, 5, 1 },
                    { 3, 6, 1 },
                    { 4, 5, 1 },
                    { 5, 8, 5 },
                    { 6, 4, 2 },
                    { 7, 6, 5 },
                    { 8, 8, 3 },
                    { 9, 3, 2 },
                    { 10, 7, 5 },
                    { 11, 4, 3 },
                    { 12, 5, 1 },
                    { 13, 5, 5 },
                    { 14, 3, 4 },
                    { 15, 4, 2 },
                    { 16, 8, 2 },
                    { 17, 4, 4 },
                    { 18, 6, 5 },
                    { 19, 6, 4 },
                    { 20, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[,]
                {
                    { 1, 7, 3, new DateTime(2024, 1, 22, 10, 3, 2, 711, DateTimeKind.Local).AddTicks(5425), 2, 8 },
                    { 2, 9, 3, new DateTime(2024, 5, 25, 20, 4, 36, 571, DateTimeKind.Local).AddTicks(104), 4, 5 },
                    { 3, 8, 3, new DateTime(2024, 5, 6, 18, 13, 35, 955, DateTimeKind.Local).AddTicks(7257), 4, 1 },
                    { 4, 6, 2, new DateTime(2024, 9, 19, 15, 45, 52, 972, DateTimeKind.Local).AddTicks(5905), 1, 1 },
                    { 5, 4, 3, new DateTime(2024, 9, 21, 0, 12, 52, 501, DateTimeKind.Local).AddTicks(3174), 2, 5 },
                    { 6, 1, 3, new DateTime(2024, 10, 11, 21, 45, 2, 591, DateTimeKind.Local).AddTicks(6752), 2, 7 },
                    { 7, 1, 3, new DateTime(2024, 11, 28, 9, 31, 49, 719, DateTimeKind.Local).AddTicks(6055), 1, 10 },
                    { 8, 8, 1, new DateTime(2024, 4, 6, 0, 35, 29, 486, DateTimeKind.Local).AddTicks(1394), 5, 8 },
                    { 9, 8, 1, new DateTime(2024, 4, 1, 12, 24, 54, 777, DateTimeKind.Local).AddTicks(3867), 2, 9 },
                    { 10, 10, 2, new DateTime(2024, 2, 7, 7, 48, 28, 70, DateTimeKind.Local).AddTicks(6795), 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "EmployeeId", "OrderDate", "ReservationId" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2023, 12, 27, 16, 46, 18, 409, DateTimeKind.Local).AddTicks(8229), 5 },
                    { 2, 5, new DateTime(2023, 12, 27, 14, 51, 42, 377, DateTimeKind.Local).AddTicks(5486), 7 },
                    { 3, 3, new DateTime(2023, 12, 27, 9, 28, 50, 725, DateTimeKind.Local).AddTicks(1856), 5 },
                    { 4, 6, new DateTime(2023, 12, 27, 17, 24, 19, 567, DateTimeKind.Local).AddTicks(2936), 1 },
                    { 5, 4, new DateTime(2023, 12, 27, 13, 51, 18, 451, DateTimeKind.Local).AddTicks(5550), 7 },
                    { 6, 4, new DateTime(2023, 12, 27, 15, 29, 36, 364, DateTimeKind.Local).AddTicks(9837), 5 },
                    { 7, 4, new DateTime(2023, 12, 27, 13, 31, 46, 762, DateTimeKind.Local).AddTicks(4958), 2 },
                    { 8, 6, new DateTime(2023, 12, 27, 16, 23, 14, 526, DateTimeKind.Local).AddTicks(6457), 10 },
                    { 9, 4, new DateTime(2023, 12, 27, 3, 17, 57, 659, DateTimeKind.Local).AddTicks(5029), 5 },
                    { 10, 1, new DateTime(2023, 12, 27, 3, 28, 23, 519, DateTimeKind.Local).AddTicks(7504), 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 6, 7, 1 },
                    { 2, 4, 1, 1 },
                    { 3, 7, 2, 1 },
                    { 4, 1, 6, 2 },
                    { 5, 9, 9, 3 },
                    { 6, 2, 8, 3 },
                    { 7, 4, 5, 5 },
                    { 8, 1, 3, 3 },
                    { 9, 6, 5, 3 },
                    { 10, 5, 6, 1 },
                    { 11, 2, 1, 1 },
                    { 12, 2, 6, 4 },
                    { 13, 6, 8, 5 },
                    { 14, 2, 3, 4 },
                    { 15, 2, 3, 1 },
                    { 16, 3, 10, 5 },
                    { 17, 6, 9, 5 },
                    { 18, 10, 7, 3 },
                    { 19, 10, 5, 5 },
                    { 20, 3, 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmount",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
