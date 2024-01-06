using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class updated_bookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aebc7f7-6528-4bcd-82ec-35e5abb698be", "AQAAAAIAAYagAAAAEBZa37Kx4w78JXh/NUuw5a/7KF4cE7rhnlE/kQt5p5v7Kt+gaZCE5pc6xXhHUwEkqA==", "c6251fb6-39d7-440f-a8bf-f90519248ae9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6435), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6054), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6065), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6665), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6668), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6671), new DateTime(2024, 1, 3, 11, 40, 11, 358, DateTimeKind.Local).AddTicks(6672) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0757142-c5a6-47f4-a86c-94d4c3b07a87", "AQAAAAIAAYagAAAAECtC0WQYMHrmppNaNf32300Pkr5rpn1fp07PLFrdGCjQkJhGe4KotHOIUPsBitsuYw==", "717073d5-1039-42e9-a8fc-7e54de4ca142" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7689), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7692), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7694), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7696), new DateTime(2024, 1, 3, 11, 37, 0, 177, DateTimeKind.Local).AddTicks(7696) });
        }
    }
}
