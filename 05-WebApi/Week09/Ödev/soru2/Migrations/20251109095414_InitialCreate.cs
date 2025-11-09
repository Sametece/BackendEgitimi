using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace soru2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    PuslishedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Content", "PuslishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Ahmet Yılmaz", "Yapay zeka hayatımızın her alanına girmeye başladı.", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yapay Zekanın Geleceği" },
                    { 2, "Elif Demir", "Microsoft, C# dilinde performans ve minimal kod odaklı yeni özellikler tanıttı.", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# 13 Yenilikleri" },
                    { 3, "Murat Kaya", "Web API geliştirme sürecinde dikkat edilmesi gereken en önemli noktaları derledik.", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET Core ile Web API" },
                    { 4, "Selin Aydın", "EF Core, ORM yapısı sayesinde veritabanı işlemlerini kolaylaştırır.", new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entity Framework Core Nedir?" },
                    { 5, "Kemal Özkan", "ASP.NET Core 6 ile gelen Minimal API yapısını örneklerle anlattık.", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minimal API Nedir?" },
                    { 6, "Ayşe Gür", "Katmanlı mimari ile sürdürülebilir kod yapısı oluşturma rehberi.", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean Architecture’a Giriş" },
                    { 7, "Hasan Tunç", "LINQ, koleksiyonlar üzerinde sorgu yazmayı kolaylaştırır.", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LINQ Sorgularını Anlamak" },
                    { 8, "Zeynep Koç", "Bağımlılıkları yönetmenin en kolay yolu: DI tasarım deseni.", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dependency Injection Basitçe" },
                    { 9, "Oğuzhan Arslan", "Birden fazla işlem tek bir iş biriminde toplandığında hata riski azalır.", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unit of Work Nedir?" },
                    { 10, "Ceren Uçar", "Veritabanı erişimini soyutlayarak temiz kod yazmak artık çok kolay.", new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repository Pattern Kullanımı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
