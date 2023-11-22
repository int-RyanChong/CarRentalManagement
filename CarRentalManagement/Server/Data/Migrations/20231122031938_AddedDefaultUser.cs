using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1f6cc6dd-f0f3-4dca-b052-d14d2c904742", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOAuTfj7hyNH2xowBuelWQb9Eg7zXxcwZvXaltIwJ2GC05Mvw+jPu+773scsmXdhVw==", null, false, "1f9cbcb4-94da-4eea-b8ab-5c09cec0290c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9260), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9267), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 11, 22, 11, 19, 37, 722, DateTimeKind.Local).AddTicks(9275) });

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

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8511), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 11, 21, 15, 49, 47, 183, DateTimeKind.Local).AddTicks(8516) });
        }
    }
}
