using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8049), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8053), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7309), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7314), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8508), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8511), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8511), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8514), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8516), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
