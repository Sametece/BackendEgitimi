using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace soru4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Title = table.Column<string>(type: "TEXT", nullable: true),
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
                    { 1, "Christopher Nolan", 2010, "Inception" },
                    { 2, "Lana Wachowski, Lilly Wachowski", 1999, "The Matrix" },
                    { 3, "Christopher Nolan", 2014, "Interstellar" },
                    { 4, "Frank Darabont", 1994, "The Shawshank Redemption" },
                    { 5, "David Fincher", 1999, "Fight Club" },
                    { 6, "Robert Zemeckis", 1994, "Forrest Gump" },
                    { 7, "Christopher Nolan", 2008, "The Dark Knight" },
                    { 8, "Quentin Tarantino", 1994, "Pulp Fiction" },
                    { 9, "Ridley Scott", 2000, "Gladiator" },
                    { 10, "James Cameron", 2009, "Avatar" }
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
