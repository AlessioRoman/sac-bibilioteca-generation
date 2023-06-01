using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace biblioteca_mvc.Migrations
{
    /// <inheritdoc />
    public partial class updatedBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Avaible",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ebook",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaible",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Ebook",
                table: "Books");
        }
    }
}
