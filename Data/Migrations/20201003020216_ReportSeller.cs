using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class ReportSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Orderid = table.Column<string>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    Evidencia1 = table.Column<string>(nullable: true),
                    Evidencia2 = table.Column<string>(nullable: true),
                    Evidencia3 = table.Column<string>(nullable: true),
                    UserMail = table.Column<string>(nullable: true),
                    Report = table.Column<DateTime>(nullable: false),
                    ReporteData = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    Sellerid = table.Column<string>(nullable: true),
                    ReferenciaPago = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reportes");
        }
    }
}
