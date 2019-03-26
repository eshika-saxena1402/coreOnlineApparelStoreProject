using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace coreOnlineApparelStoreAdminPortal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AlternatePhoneNumber",
                table: "Customers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Country2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode2",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    ItemCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.CustomerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Carts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    FeedBackId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => new { x.ProductId, x.OrderId });
                    table.UniqueConstraint("AK_FeedBacks_OrderId_ProductId", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_FeedBacks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerId",
                table: "Carts",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "AlternatePhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ZipCode2",
                table: "Customers");
        }
    }
}
