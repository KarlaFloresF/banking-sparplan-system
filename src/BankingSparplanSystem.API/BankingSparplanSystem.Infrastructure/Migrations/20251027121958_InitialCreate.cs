using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingSparplanSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunden",
                columns: table => new
                {
                    KundeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefonnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunden", x => x.KundeId);
                });

            migrationBuilder.CreateTable(
                name: "Sparplaene",
                columns: table => new
                {
                    SparplanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Typ = table.Column<int>(type: "int", nullable: false),
                    Zielbetrag = table.Column<decimal>(type: "decimal(18,5)", precision: 18, scale: 5, nullable: false),
                    KundeId = table.Column<int>(type: "int", nullable: false),
                    MonatlicheZahlung = table.Column<int>(type: "int", nullable: false),
                    Vertragsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stornierungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IstAktiviert = table.Column<bool>(type: "bit", nullable: false),
                    BarrenMenge = table.Column<decimal>(type: "decimal(18,5)", precision: 18, scale: 5, nullable: false),
                    GewünschteSpargrenze = table.Column<decimal>(type: "decimal(18,5)", precision: 18, scale: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sparplaene", x => x.SparplanId);
                    table.ForeignKey(
                        name: "FK_Sparplaene_Kunden_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunden",
                        principalColumn: "KundeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sparplaene_KundeId",
                table: "Sparplaene",
                column: "KundeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sparplaene");

            migrationBuilder.DropTable(
                name: "Kunden");
        }
    }
}
