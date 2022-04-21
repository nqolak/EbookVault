using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EbookVault.Infrastructure.Migrations
{
    public partial class RenamedMessageProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Messages",
                newName: "MessageText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageText",
                table: "Messages",
                newName: "Content");
        }
    }
}
