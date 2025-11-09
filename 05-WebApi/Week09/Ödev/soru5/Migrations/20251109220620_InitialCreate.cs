using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace soru5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "ahmet.yilmaz@example.com", "Ahmet", "Yılmaz", "0532 111 2233" },
                    { 2, "ayse.demir@example.com", "Ayşe", "Demir", "0543 222 3344" },
                    { 3, "mehmet.kaya@example.com", "Mehmet", "Kaya", "0551 333 4455" },
                    { 4, "fatma.sahin@example.com", "Fatma", "Şahin", "0505 444 5566" },
                    { 5, "ali.celik@example.com", "Ali", "Çelik", "0530 555 6677" },
                    { 6, "zeynep.aydin@example.com", "Zeynep", "Aydın", "0544 666 7788" },
                    { 7, "emre.koc@example.com", "Emre", "Koç", "0522 777 8899" },
                    { 8, "elif.arslan@example.com", "Elif", "Arslan", "0555 888 9900" },
                    { 9, "hasan.dogan@example.com", "Hasan", "Doğan", "0531 999 0011" },
                    { 10, "merve.kurt@example.com", "Merve", "Kurt", "0506 101 1122" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
