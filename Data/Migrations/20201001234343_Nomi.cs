using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class Nomi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nomina",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Sellerid = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Retired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomina", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nomina");
        }
    }
}
