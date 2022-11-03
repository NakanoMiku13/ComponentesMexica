using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class Rifas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ganadores",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    userid = table.Column<string>(nullable: true),
                    Rifaid = table.Column<string>(nullable: true),
                    CantidadTickets = table.Column<int>(nullable: false),
                    NumeroWin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ganadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rifas",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Componenteid = table.Column<int>(nullable: false),
                    GanadorUserid = table.Column<string>(nullable: true),
                    Rifado = table.Column<DateTime>(nullable: false),
                    Tickets = table.Column<int>(nullable: false),
                    Acumulado = table.Column<decimal>(nullable: false),
                    NumeroWin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rifas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rifas_Componente_Componenteid",
                        column: x => x.Componenteid,
                        principalTable: "Componente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(nullable: true),
                    Rifaid = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    Comprado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rifas_Componenteid",
                table: "Rifas",
                column: "Componenteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ganadores");

            migrationBuilder.DropTable(
                name: "Rifas");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
