using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chat.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    PublishedYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { 1, "George Orwell", "Dystopian", 1949, "1984" },
                    { 2, "Harper Lee", "Classic", 1960, "To Kill a Mockingbird" },
                    { 3, "F. Scott Fitzgerald", "Novel", 1925, "The Great Gatsby" },
                    { 4, "Herman Melville", "Adventure", 1851, "Moby-Dick" },
                    { 5, "Jane Austen", "Romance", 1813, "Pride and Prejudice" },
                    { 6, "J.D. Salinger", "Fiction", 1951, "The Catcher in the Rye" },
                    { 7, "J.R.R. Tolkien", "Fantasy", 1937, "The Hobbit" },
                    { 8, "Aldous Huxley", "Science Fiction", 1932, "Brave New World" },
                    { 9, "Paulo Coelho", "Philosophical", 1988, "The Alchemist" },
                    { 10, "Fyodor Dostoevsky", "Psychological", 1866, "Crime and Punishment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
