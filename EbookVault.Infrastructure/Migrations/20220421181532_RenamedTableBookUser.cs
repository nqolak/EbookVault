using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EbookVault.Infrastructure.Migrations
{
    public partial class RenamedTableBookUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BookUser", 
                newName: "UsersBooks");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "UsersBooks",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "UsersBooks",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UsersBooks",
                newName: "BookUser");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookUser",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BookUser",
                newName: "UsersId");
        }
    }
}
