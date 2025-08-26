using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DartVerwaltung.Migrations
{
    /// <inheritdoc />
    public partial class changesthree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MemberNumber",
                table: "Members",
                newName: "Nr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nr",
                table: "Members",
                newName: "MemberNumber");
        }
    }
}
