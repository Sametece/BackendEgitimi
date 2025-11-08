using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Soru1.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "H. Moritz", 2005, "Hızlı ve Öfkeli" },
                    { 2, "Peter Jackson", 2003, "Yüzüklerin Efendisi: Kralın Dönüşü" },
                    { 3, "Christopher Nolan", 2010, "Başlangıç" },
                    { 4, "Lana Wachowski, Lilly Wachowski", 1999, "Matrix" },
                    { 5, "Ridley Scott", 2000, "Gladyatör" },
                    { 6, "James Cameron", 2009, "Avatar" },
                    { 7, "Todd Phillips", 2019, "Joker" },
                    { 8, "Christopher Nolan", 2014, "Interstellar" },
                    { 9, "Gore Verbinski", 2003, "Karayip Korsanları: Siyah İnci'nin Laneti" },
                    { 10, "James Cameron", 1997, "Titanic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
