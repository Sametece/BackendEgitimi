using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project33_WebApiActionMethods.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "6.1 inç Super Retina XDR ekranlı, A16 Bionic çipli akıllı telefon", "Apple iPhone 15", 49999m },
                    { 2, "4K UHD çözünürlük, HDR10+ destekli 55 inç akıllı televizyon", "Samsung 55'' QLED TV", 29999m },
                    { 3, "Lazerli kablosuz dik süpürge, güçlü emiş gücü ve toz algılama teknolojisi", "Dyson V15 Detect", 25999m },
                    { 4, "Gürültü engelleyici kablosuz kulaklık, yüksek çözünürlüklü ses desteği", "Sony WH-1000XM5", 14999m },
                    { 5, "14'' ekran, AMD Ryzen 9 işlemci, RTX 4060 ekran kartlı gaming laptop", "Asus ROG Zephyrus G14", 64999m },
                    { 6, "Hava taban teknolojili spor ayakkabı, konfor ve stil bir arada", "Nike Air Max 270", 4999m },
                    { 7, "Yağsız fritöz, sıcak hava teknolojisiyle sağlıklı kızartmalar", "Philips Airfryer XXL", 8999m },
                    { 8, "Darbeye dayanıklı, su geçirmez analog-dijital kol saati", "Casio G-Shock GA-2100", 3999m },
                    { 9, "Ergonomik kablosuz mouse, sessiz tıklama ve hızlı şarj desteği", "Logitech MX Master 3S", 3299m },
                    { 10, "6.8 inç aydınlatmalı e-kitap okuyucu, suya dayanıklı tasarım", "Kindle Paperwhite 11. Nesil", 5999m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
