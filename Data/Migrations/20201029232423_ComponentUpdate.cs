using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class ComponentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacidad",
                table: "Componente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Formato",
                table: "Componente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wattage",
                table: "Componente",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacidad",
                table: "Componente");

            migrationBuilder.DropColumn(
                name: "Formato",
                table: "Componente");

            migrationBuilder.DropColumn(
                name: "Wattage",
                table: "Componente");
        }
    }
}
