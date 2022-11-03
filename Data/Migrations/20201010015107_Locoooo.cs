using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class Locoooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantTickets",
                table: "RifaOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rifaid",
                table: "RifaOrders",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "RifaOrders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Cooler",
                table: "PCMR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RAM1",
                table: "PCMR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RAM2",
                table: "PCMR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RAM3",
                table: "PCMR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SSDM2",
                table: "PCMR",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantTickets",
                table: "RifaOrders");

            migrationBuilder.DropColumn(
                name: "Rifaid",
                table: "RifaOrders");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "RifaOrders");

            migrationBuilder.DropColumn(
                name: "Cooler",
                table: "PCMR");

            migrationBuilder.DropColumn(
                name: "RAM1",
                table: "PCMR");

            migrationBuilder.DropColumn(
                name: "RAM2",
                table: "PCMR");

            migrationBuilder.DropColumn(
                name: "RAM3",
                table: "PCMR");

            migrationBuilder.DropColumn(
                name: "SSDM2",
                table: "PCMR");
        }
    }
}
