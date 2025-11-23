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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "İstanbul", "sametece@developer.com", "Samet", "Ece" },
                    { 2, "Ankara", "ahmet.yilmaz@example.com", "Ahmet", "Yılmaz" },
                    { 3, "İzmir", "mehmet.demir@example.com", "Mehmet", "Demir" },
                    { 4, "Bursa", "ayse.kara@example.com", "Ayşe", "Kara" },
                    { 5, "Antalya", "fatma.celik@example.com", "Fatma", "Çelik" },
                    { 6, "Eskişehir", "can.aydin@example.com", "Can", "Aydın" },
                    { 7, "Konya", "merve.sahin@example.com", "Merve", "Şahin" },
                    { 8, "Samsun", "ali.gunes@example.com", "Ali", "Güneş" },
                    { 9, "Gaziantep", "zeynep.kurt@example.com", "Zeynep", "Kurt" },
                    { 10, "Trabzon", "burak.tas@example.com", "Burak", "Taş" }
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
