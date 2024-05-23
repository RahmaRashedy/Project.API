using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Users_UserId1",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_UserId1",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 1, 46, 7, 470, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 1, 46, 7, 470, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 1, 46, 7, 470, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 1, 46, 7, 470, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 1, 46, 7, 470, DateTimeKind.Local).AddTicks(986));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CartItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 5, 22, 1, 39, 34, 749, DateTimeKind.Local).AddTicks(4632), 0, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 5, 22, 1, 39, 34, 749, DateTimeKind.Local).AddTicks(4675), 0, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 5, 22, 1, 39, 34, 749, DateTimeKind.Local).AddTicks(4678), 0, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 5, 22, 1, 39, 34, 749, DateTimeKind.Local).AddTicks(4681), 0, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 5, 22, 1, 39, 34, 749, DateTimeKind.Local).AddTicks(4683), 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserId1",
                table: "CartItems",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Users_UserId1",
                table: "CartItems",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
