using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class addUserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "393c628a-19ea-4943-982d-126784b932bf", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEexhGm08pYpmVCt/vdg3FeDZPQ1l1h5CGUw13pxCUtCrM6ObtR74YdovCg/2Q5VGg==", null, false, "214f05df-dfd4-4e1b-98ce-588fa487a337", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3807), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3820), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3966), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3968), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(4032), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(4034), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(4035), new DateTime(2025, 11, 26, 10, 7, 30, 103, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2147), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2158), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2296), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2298), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2354), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2356), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2357), new DateTime(2025, 11, 26, 9, 35, 34, 829, DateTimeKind.Local).AddTicks(2358) });
        }
    }
}
