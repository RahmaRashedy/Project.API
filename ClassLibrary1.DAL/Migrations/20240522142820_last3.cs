using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.DAL.Migrations
{
    /// <inheritdoc />
    public partial class last3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Orders_OrderId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "cartItems");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductId",
                table: "cartItems",
                newName: "IX_cartItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_OrderId",
                table: "cartItems",
                newName: "IX_cartItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cartItems",
                table: "cartItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 28, 19, 602, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 28, 19, 602, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 28, 19, 602, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 28, 19, 602, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 17, 28, 19, 602, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.AddForeignKey(
                name: "FK_cartItems_Products_ProductId",
                table: "cartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cartItems_orders_OrderId",
                table: "cartItems",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartItems_Products_ProductId",
                table: "cartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_cartItems_orders_OrderId",
                table: "cartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cartItems",
                table: "cartItems");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "cartItems",
                newName: "CartItems");

            migrationBuilder.RenameIndex(
                name: "IX_cartItems_ProductId",
                table: "CartItems",
                newName: "IX_CartItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_cartItems_OrderId",
                table: "CartItems",
                newName: "IX_CartItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 16, 26, 32, 305, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 16, 26, 32, 305, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 16, 26, 32, 305, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 16, 26, 32, 305, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 16, 26, 32, 305, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Orders_OrderId",
                table: "CartItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
