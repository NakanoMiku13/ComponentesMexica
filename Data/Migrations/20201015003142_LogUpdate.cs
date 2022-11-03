using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class LogUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Logged",
                table: "Logs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logged",
                table: "Logs");
        }
    }
}
