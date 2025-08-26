using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DartVerwaltung.Migrations
{
    /// <inheritdoc />
    public partial class changesTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alter",
                table: "Members");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Geburtstag",
                table: "Members",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Geburtstag",
                table: "Members",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Alter",
                table: "Members",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
