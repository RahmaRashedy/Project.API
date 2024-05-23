using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mgg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 23, 8, 990, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 23, 8, 990, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 23, 8, 990, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 23, 8, 990, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 23, 8, 990, DateTimeKind.Local).AddTicks(9412));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 34, 36, 453, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 34, 36, 453, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 34, 36, 453, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 34, 36, 453, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 34, 36, 453, DateTimeKind.Local).AddTicks(9629));
        }
    }
}
