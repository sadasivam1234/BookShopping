using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopping.Migrations
{
    /// <inheritdoc />
    public partial class AddTableUsertoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Reg_Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reg_Users",
                table: "Reg_Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reg_Users",
                table: "Reg_Users");

            migrationBuilder.RenameTable(
                name: "Reg_Users",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
