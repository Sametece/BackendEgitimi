using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditedOrderEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Orders",
                newName: "AppUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c5e6042-9145-42cb-8220-e4aab7ea0cdb",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECIdBBLloQff41bNUxaDxN02Usa/DsWbQEsgQkSz0ZGeEnOposbMzyrhLgGnXvTurQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819bee56-04d5-4ba7-8bd4-109d7607af95",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEALZJd8v+Qisg4lXnZHFYuW+jEOqOIscyecR54lmfyOHCTiobJg8z4NBFsg00rSy1A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8c5e701-43ad-4949-ac22-32385e7cfd88",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK/DX7ELvfkhFMI1zf9EOPD3YZ6yxsd8zp+LewpF8OoOT9WY91irLrqy7RSaJLrd1A==");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Orders",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c5e6042-9145-42cb-8220-e4aab7ea0cdb",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBahs4GRTwlfxn8M/uFHmhFb4kzD2+ILc1HnC6sIH7UbsVHXLhxTYX9OhNm1kTcfKA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819bee56-04d5-4ba7-8bd4-109d7607af95",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDdPhSi4l3pVkisFCOqBwC70nZaG9YwlEUnHd5IlzkNaftMwQuEUd2nJQRIWpWVgUg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8c5e701-43ad-4949-ac22-32385e7cfd88",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOfS5tR0pBEUKhaSWOXy+3KnsbqHBdNLaG/jZu5pd0EJxtC+56JAv4/Y8gTL2dfOXA==");
        }
    }
}
