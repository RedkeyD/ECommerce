using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_cart_id",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_product_id",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_user_id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_order_id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_product_id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_category_id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_product_id",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_user_id",
                table: "Reviews");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_public_id",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Reviews_public_id",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_public_id",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Orders_public_id",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OrderItems_public_id",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Categories_public_id",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Carts_public_id",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_CartItems_public_id",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "review");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "order");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "order_item");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "category");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "cart");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "cart_item");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_user_id",
                table: "review",
                newName: "IX_review_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_product_id",
                table: "review",
                newName: "IX_review_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_category_id",
                table: "product",
                newName: "IX_product_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_user_id",
                table: "order",
                newName: "IX_order_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_product_id",
                table: "order_item",
                newName: "IX_order_item_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_order_id",
                table: "order_item",
                newName: "IX_order_item_order_id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_user_id",
                table: "cart",
                newName: "IX_cart_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_product_id",
                table: "cart_item",
                newName: "IX_cart_item_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_cart_id",
                table: "cart_item",
                newName: "IX_cart_item_cart_id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_user_public_id",
                table: "user",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_review_public_id",
                table: "review",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_review",
                table: "review",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_product_public_id",
                table: "product",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_order_public_id",
                table: "order",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_order_item_public_id",
                table: "order_item",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_item",
                table: "order_item",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_category_public_id",
                table: "category",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category",
                table: "category",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_cart_public_id",
                table: "cart",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cart",
                table: "cart",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_cart_item_public_id",
                table: "cart_item",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cart_item",
                table: "cart_item",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_user_user_id",
                table: "cart",
                column: "user_id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_item_cart_cart_id",
                table: "cart_item",
                column: "cart_id",
                principalTable: "cart",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_item_product_product_id",
                table: "cart_item",
                column: "product_id",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_user_user_id",
                table: "order",
                column: "user_id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_item_order_order_id",
                table: "order_item",
                column: "order_id",
                principalTable: "order",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_item_product_product_id",
                table: "order_item",
                column: "product_id",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_category_id",
                table: "product",
                column: "category_id",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_review_product_product_id",
                table: "review",
                column: "product_id",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_review_user_user_id",
                table: "review",
                column: "user_id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_user_user_id",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_item_cart_cart_id",
                table: "cart_item");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_item_product_product_id",
                table: "cart_item");

            migrationBuilder.DropForeignKey(
                name: "FK_order_user_user_id",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_item_order_order_id",
                table: "order_item");

            migrationBuilder.DropForeignKey(
                name: "FK_order_item_product_product_id",
                table: "order_item");

            migrationBuilder.DropForeignKey(
                name: "FK_product_category_category_id",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_review_product_product_id",
                table: "review");

            migrationBuilder.DropForeignKey(
                name: "FK_review_user_user_id",
                table: "review");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_user_public_id",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_review_public_id",
                table: "review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_review",
                table: "review");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_product_public_id",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_order_item_public_id",
                table: "order_item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_item",
                table: "order_item");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_order_public_id",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_category_public_id",
                table: "category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_category",
                table: "category");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_cart_item_public_id",
                table: "cart_item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cart_item",
                table: "cart_item");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_cart_public_id",
                table: "cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cart",
                table: "cart");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "order_item",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "cart_item",
                newName: "CartItems");

            migrationBuilder.RenameTable(
                name: "cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_review_user_id",
                table: "Reviews",
                newName: "IX_Reviews_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_review_product_id",
                table: "Reviews",
                newName: "IX_Reviews_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_product_category_id",
                table: "Products",
                newName: "IX_Products_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_order_item_product_id",
                table: "OrderItems",
                newName: "IX_OrderItems_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_order_item_order_id",
                table: "OrderItems",
                newName: "IX_OrderItems_order_id");

            migrationBuilder.RenameIndex(
                name: "IX_order_user_id",
                table: "Orders",
                newName: "IX_Orders_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_cart_item_product_id",
                table: "CartItems",
                newName: "IX_CartItems_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_cart_item_cart_id",
                table: "CartItems",
                newName: "IX_CartItems_cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_cart_user_id",
                table: "Carts",
                newName: "IX_Carts_user_id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_public_id",
                table: "Users",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Reviews_public_id",
                table: "Reviews",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_public_id",
                table: "Products",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OrderItems_public_id",
                table: "OrderItems",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Orders_public_id",
                table: "Orders",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Categories_public_id",
                table: "Categories",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_CartItems_public_id",
                table: "CartItems",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Carts_public_id",
                table: "Carts",
                column: "public_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_cart_id",
                table: "CartItems",
                column: "cart_id",
                principalTable: "Carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_product_id",
                table: "CartItems",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_user_id",
                table: "Carts",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_order_id",
                table: "OrderItems",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_product_id",
                table: "OrderItems",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_category_id",
                table: "Products",
                column: "category_id",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_product_id",
                table: "Reviews",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_user_id",
                table: "Reviews",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
