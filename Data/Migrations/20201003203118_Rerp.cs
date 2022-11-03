using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class Rerp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersSeller",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    sellerid = table.Column<string>(nullable: true),
                    Prodid = table.Column<string>(nullable: true),
                    Enviado = table.Column<bool>(nullable: false),
                    Oculto = table.Column<bool>(nullable: false),
                    userid = table.Column<string>(nullable: true),
                    RefPago = table.Column<string>(nullable: true),
                    orderid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersSeller", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RerporteSeller",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    useridSeller = table.Column<string>(nullable: true),
                    reportid = table.Column<string>(nullable: true),
                    Cuenta = table.Column<int>(nullable: false),
                    Sellerid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RerporteSeller", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersSeller");

            migrationBuilder.DropTable(
                name: "RerporteSeller");
        }
    }
}
