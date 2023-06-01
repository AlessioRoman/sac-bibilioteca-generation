using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace biblioteca_mvc.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBooksName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Avaible",
                table: "Books",
                newName: "Available");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Available",
                table: "Books",
                newName: "Avaible");
        }
    }
}
