using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class RetireSellerDinero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RetiroDinero",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Sellerid = table.Column<string>(nullable: true),
                    Aproved = table.Column<bool>(nullable: false),
                    Termino = table.Column<bool>(nullable: false),
                    Solicitado = table.Column<DateTime>(nullable: false),
                    Employeeid = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Metodo = table.Column<string>(nullable: true),
                    ReferenciaSeller = table.Column<string>(nullable: true),
                    ReferenciaRetiro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetiroDinero", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RetiroDinero");
        }
    }
}
