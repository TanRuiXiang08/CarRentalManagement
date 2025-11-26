using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DataCreated", "DataUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9058), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9060), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9061), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DataCreated", "DataUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9217), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9218), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9219), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9220), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DataCreated", "DataUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9313), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9314), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9315), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9316), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9317), new DateTime(2025, 11, 24, 11, 57, 59, 988, DateTimeKind.Local).AddTicks(9317), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
