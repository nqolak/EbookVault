using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EbookVault.Infrastructure.Migrations
{
    public partial class RenamedTableBookGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BookGenre",
                newName: "BooksGenres");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "BooksGenres",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "BooksGenres",
                newName: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "BooksGenres",
                newName: "BookGenre");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookGenre",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "BookGenre",
                newName: "GenresId");
        }
    }
}
