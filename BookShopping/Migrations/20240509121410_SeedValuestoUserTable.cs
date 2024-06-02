using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShopping.Migrations
{
    /// <inheritdoc />
    public partial class SeedValuestoUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reg_Users",
                columns: new[] { "Id", "Name", "email", "password", "re_password" },
                values: new object[,]
                {
                    { 1, "Sadasivam", "sadasivam@gmail.com", "sada", "sada" },
                    { 2, "Abcd", "abcd@gmail.com", "abcd", "abcd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reg_Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reg_Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
