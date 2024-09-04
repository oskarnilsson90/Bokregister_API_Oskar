using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bokregister_API_Oskar.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueConstraintToIsbn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Books_ISBN",
                table: "Books",
                column: "ISBN",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_ISBN",
                table: "Books");
        }
    }
}
