using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd66d9d0-5aac-42a3-bd53-12ac0574cf1c", "c4addbe1-adbc-4002-90dd-c4c2391eafb5", "Yönetici Rolü", "Admin", "ADMIN" },
                    { "e676b617-bec3-4b92-a746-dfc5043ebe08", "ef25dd62-cbbc-45aa-8405-ffa6d8926664", "Kullanıcı Rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6c5e6042-9145-42cb-8220-e4aab7ea0cdb", 0, "2f9ab541-0444-4ed4-beb6-10edae0e65bf", "selindag@example.com", true, "Selin", "Dağ", false, null, "SELINDAG@EXAMPLE.COM", "SELINDAG", "AQAAAAIAAYagAAAAEIhG7dWo4n0dhR6ixzkTTzu2T04ID+UZw2OLlZrxpsMUj2kjJ4oJCpnC6g2bjO1wCA==", null, false, "8d096aa5-6071-4e16-8c8e-ecf542ec361d", false, "selindag" },
                    { "819bee56-04d5-4ba7-8bd4-109d7607af95", 0, "087729db-48a9-434f-90a0-4fe1af527ff8", "denizkerem@example.com", true, "Deniz", "Kerem", false, null, "DENIZKEREM@EXAMPLE.COM", "DENIZKEREM", "AQAAAAIAAYagAAAAEGAcImcCXWSqwIdup2dz+XZgjI+YRGJWbxz6ocT1P3DYUhDi8UDECgjniGs2Vnj7Tw==", null, false, "a9aa84f6-6a60-45de-9070-40d23d2f403b", false, "denizkerem" },
                    { "a8c5e701-43ad-4949-ac22-32385e7cfd88", 0, "cfe87fd5-71af-41b1-98fe-8f16123a4966", "ferdacan@example.com", true, "Ferda", "Can", false, null, "FERDACAN@EXAMPLE.COM", "FERDACAN", "AQAAAAIAAYagAAAAEF5Rtk+BoTFqH4BVugsskNuRR2zLNpxsJ7BO+x8zt+1Smm9xkuyxjkzk3y32BMcoJg==", null, false, "c1eeafd8-8177-4e60-ba9b-d67ab8f53be8", false, "ferdacan" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e676b617-bec3-4b92-a746-dfc5043ebe08", "6c5e6042-9145-42cb-8220-e4aab7ea0cdb" },
                    { "dd66d9d0-5aac-42a3-bd53-12ac0574cf1c", "819bee56-04d5-4ba7-8bd4-109d7607af95" },
                    { "e676b617-bec3-4b92-a746-dfc5043ebe08", "a8c5e701-43ad-4949-ac22-32385e7cfd88" }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
