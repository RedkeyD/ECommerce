using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    name = table.Column<string>( type: "character varying(50)", maxLength: 50, nullable: false ),
                    description = table.Column<string>( type: "character varying(1500)", maxLength: 1500, nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Categories", x => x.id );
                    table.UniqueConstraint( "AK_Categories_public_id", x => x.public_id );
                } );

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    username = table.Column<string>( type: "character varying(20)", maxLength: 20, nullable: false ),
                    email = table.Column<string>( type: "character varying(50)", maxLength: 50, nullable: false ),
                    passsword_hash = table.Column<string>( type: "character varying(50)", maxLength: 50, nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Users", x => x.id );
                    table.UniqueConstraint( "AK_Users_public_id", x => x.public_id );
                } );

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    name = table.Column<string>( type: "character varying(20)", maxLength: 20, nullable: false ),
                    description = table.Column<string>( type: "character varying(1500)", maxLength: 1500, nullable: false ),
                    price = table.Column<decimal>( type: "numeric", nullable: false ),
                    category_id = table.Column<long>( type: "bigint", nullable: false ),
                    image_url = table.Column<string>( type: "text", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Products", x => x.id );
                    table.UniqueConstraint( "AK_Products_public_id", x => x.public_id );
                    table.ForeignKey(
                        name: "FK_Products_Categories_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    user_id = table.Column<long>( type: "bigint", nullable: false ),
                    created_date = table.Column<DateTime>( type: "timestamp with time zone", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Carts", x => x.id );
                    table.UniqueConstraint( "AK_Carts_public_id", x => x.public_id );
                    table.ForeignKey(
                        name: "FK_Carts_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    user_id = table.Column<long>( type: "bigint", nullable: false ),
                    order_date = table.Column<DateTime>( type: "timestamp with time zone", nullable: false ),
                    status = table.Column<int>( type: "integer", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Orders", x => x.id );
                    table.UniqueConstraint( "AK_Orders_public_id", x => x.public_id );
                    table.ForeignKey(
                        name: "FK_Orders_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    product_id = table.Column<long>( type: "bigint", nullable: false ),
                    user_id = table.Column<long>( type: "bigint", nullable: false ),
                    rating = table.Column<int>( type: "integer", nullable: false ),
                    comment = table.Column<string>( type: "character varying(1500)", maxLength: 1500, nullable: false ),
                    review_date = table.Column<DateTime>( type: "timestamp with time zone", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Reviews", x => x.id );
                    table.UniqueConstraint( "AK_Reviews_public_id", x => x.public_id );
                    table.ForeignKey(
                        name: "FK_Reviews_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                    table.ForeignKey(
                        name: "FK_Reviews_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    cart_id = table.Column<long>( type: "bigint", nullable: false ),
                    product_id = table.Column<long>( type: "bigint", nullable: false ),
                    quantity = table.Column<int>( type: "integer", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_CartItems", x => x.id );
                    table.UniqueConstraint( "AK_CartItems_public_id", x => x.public_id );
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_cart_id",
                        column: x => x.cart_id,
                        principalTable: "Carts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                    table.ForeignKey(
                        name: "FK_CartItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    id = table.Column<long>( type: "bigint", nullable: false )
                        .Annotation( "Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn ),
                    public_id = table.Column<Guid>( type: "uuid", nullable: false ),
                    order_id = table.Column<long>( type: "bigint", nullable: false ),
                    product_id = table.Column<long>( type: "bigint", nullable: false ),
                    quantity = table.Column<decimal>( type: "numeric", nullable: false ),
                    price = table.Column<decimal>( type: "numeric", nullable: false ),
                    currency = table.Column<string>( type: "text", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_OrderItems", x => x.id );
                    table.UniqueConstraint( "AK_OrderItems_public_id", x => x.public_id );
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_order_id",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_cart_id",
                table: "CartItems",
                column: "cart_id" );

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_product_id",
                table: "CartItems",
                column: "product_id" );

            migrationBuilder.CreateIndex(
                name: "IX_Carts_user_id",
                table: "Carts",
                column: "user_id",
                unique: true );

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_order_id",
                table: "OrderItems",
                column: "order_id" );

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_product_id",
                table: "OrderItems",
                column: "product_id" );

            migrationBuilder.CreateIndex(
                name: "IX_Orders_user_id",
                table: "Orders",
                column: "user_id" );

            migrationBuilder.CreateIndex(
                name: "IX_Products_category_id",
                table: "Products",
                column: "category_id" );

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_product_id",
                table: "Reviews",
                column: "product_id" );

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_user_id",
                table: "Reviews",
                column: "user_id" );
        }

        /// <inheritdoc />
        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropTable(
                name: "CartItems" );

            migrationBuilder.DropTable(
                name: "OrderItems" );

            migrationBuilder.DropTable(
                name: "Reviews" );

            migrationBuilder.DropTable(
                name: "Carts" );

            migrationBuilder.DropTable(
                name: "Orders" );

            migrationBuilder.DropTable(
                name: "Products" );

            migrationBuilder.DropTable(
                name: "Users" );

            migrationBuilder.DropTable(
                name: "Categories" );
        }
    }
}
