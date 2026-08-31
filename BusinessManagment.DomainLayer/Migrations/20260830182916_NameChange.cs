using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessManagment.DomainLayer.Migrations
{
    /// <inheritdoc />
    public partial class NameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_item_Order_OrderId",
                table: "order_item");

            migrationBuilder.DropForeignKey(
                name: "FK_order_item_Product_ProductId",
                table: "order_item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_item",
                table: "order_item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_history",
                table: "order_history");

            migrationBuilder.RenameTable(
                name: "order_item",
                newName: "OrderItem");

            migrationBuilder.RenameTable(
                name: "order_history",
                newName: "OrderHistory");

            migrationBuilder.RenameIndex(
                name: "IX_order_item_ProductId",
                table: "OrderItem",
                newName: "IX_OrderItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_order_item_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderHistory",
                table: "OrderHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_ProductId",
                table: "OrderItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_ProductId",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderHistory",
                table: "OrderHistory");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "order_item");

            migrationBuilder.RenameTable(
                name: "OrderHistory",
                newName: "order_history");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_ProductId",
                table: "order_item",
                newName: "IX_order_item_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "order_item",
                newName: "IX_order_item_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_item",
                table: "order_item",
                column: "OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_history",
                table: "order_history",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_item_Order_OrderId",
                table: "order_item",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_item_Product_ProductId",
                table: "order_item",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
