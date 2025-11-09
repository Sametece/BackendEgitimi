using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace soru3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "Description", "DueDate", "IsCompleted", "Title" },
                values: new object[,]
                {
                    { 1, "Market alışverişini tamamla", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Alışveriş Yap" },
                    { 2, "Elektrik ve internet faturalarını öde", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Faturaları Öde" },
                    { 3, "Saat 14:00'te proje toplantısına katıl", new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Toplantıya Katıl" },
                    { 4, "30 dakika yürüyüş yap", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Egzersiz Yap" },
                    { 5, "Her gün 20 sayfa kitap oku", new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Kitap Oku" },
                    { 6, "Gelen kutusunu düzenle ve önemli mailleri yanıtla", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "E-posta Kontrolü" },
                    { 7, "Pazartesi toplantısı için PowerPoint sunumunu hazırla", new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sunum Hazırla" },
                    { 8, "Yağ ve filtre değişimi yaptır", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Araç Bakımı" },
                    { 9, "Uzun zamandır konuşmadığın bir arkadaşını ara", new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Arkadaşını Ara" },
                    { 10, "Listendeki filmi izle ve notlarını al", new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Film İzle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoTasks");
        }
    }
}
