using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class LogUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pWDLogs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Pwd = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Valid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pWDLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pWDLogs");
        }
    }
}
