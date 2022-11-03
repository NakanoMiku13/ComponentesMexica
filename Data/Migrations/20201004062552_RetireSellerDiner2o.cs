using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class RetireSellerDiner2o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RifaOrders",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    userid = table.Column<string>(nullable: true),
                    total = table.Column<decimal>(nullable: false),
                    Acreditado = table.Column<bool>(nullable: false),
                    ReferenciaPago = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RifaOrders", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RifaOrders");
        }
    }
}
