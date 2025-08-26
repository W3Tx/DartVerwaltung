using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DartVerwaltung.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vorname = table.Column<string>(type: "TEXT", nullable: false),
                    Nachname = table.Column<string>(type: "TEXT", nullable: false),
                    Titel = table.Column<string>(type: "TEXT", nullable: false),
                    Familienstand = table.Column<string>(type: "TEXT", nullable: false),
                    Geburtstag = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alter = table.Column<int>(type: "INTEGER", nullable: false),
                    Eintrittsdatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Austrittsdatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Beruf = table.Column<string>(type: "TEXT", nullable: false),
                    Informationen = table.Column<string>(type: "TEXT", nullable: false),
                    Profilbild = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
