using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Güncel akıllı telefon modelleri", false, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akıllı Telefonlar" },
                    { 2, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telefon aksesuarları ve tamamlayıcı ürünler", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuarlar" },
                    { 3, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genel elektronik ürünler", false, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsDeleted", "ModifiedAt", "Name", "Price", "Properties", "StockQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 16 Pro", 72000m, null, 12 },
                    { 2, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 16", 64000m, null, 20 },
                    { 3, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S25 Ultra", 68000m, null, 15 },
                    { 4, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi 14 Ultra", 52000m, null, 30 },
                    { 5, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google Pixel 9 Pro", 58000m, null, 18 },
                    { 6, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple AirPods Pro 3", 12000m, null, 50 },
                    { 7, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Buds 3 Pro", 9000m, null, 60 },
                    { 8, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anker PowerCore 30000 mAh", 3500m, null, 100 },
                    { 9, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baseus GaN 65W Şarj Cihazı", 2500m, null, 80 },
                    { 10, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logitech MX Master 4", 6000m, null, 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 1, 6 },
                    { 2, 6 },
                    { 3, 6 },
                    { 1, 7 },
                    { 2, 7 },
                    { 3, 7 },
                    { 1, 8 },
                    { 2, 8 },
                    { 3, 8 },
                    { 1, 9 },
                    { 2, 9 },
                    { 3, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
