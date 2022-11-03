using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentesMexica.Data.Migrations
{
    public partial class ModelsUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DataEntity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataEntity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Edit",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Componenteid = table.Column<int>(nullable: false),
                    Employeeid = table.Column<string>(nullable: true),
                    Edit = table.Column<string>(nullable: true),
                    EditedTime = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Entidad",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataI = table.Column<string>(nullable: true),
                    Asenta = table.Column<string>(nullable: true),
                    TipoAsenta = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    CEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Colonia = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Politicas = table.Column<bool>(nullable: false),
                    Entregado = table.Column<bool>(nullable: false),
                    MetodoPago = table.Column<string>(nullable: true),
                    Acreditado = table.Column<bool>(nullable: false),
                    Enviado = table.Column<bool>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Ordenado = table.Column<DateTime>(nullable: false),
                    EntregaEstimada = table.Column<DateTime>(nullable: false),
                    MetodoEnvio = table.Column<string>(nullable: true),
                    RefPago = table.Column<string>(nullable: true),
                    Devolucion = table.Column<bool>(nullable: false),
                    Cancelado = table.Column<bool>(nullable: false),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PCMR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    CPU = table.Column<string>(nullable: true),
                    Mobo = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    PCU = table.Column<string>(nullable: true),
                    RAM = table.Column<string>(nullable: true),
                    Almacenamiento = table.Column<string>(nullable: true),
                    AlmacenamientoSecu = table.Column<string>(nullable: true),
                    Case = table.Column<string>(nullable: true),
                    PrecioVenta = table.Column<decimal>(nullable: false),
                    PrecioComision = table.Column<decimal>(nullable: false),
                    Ganancia = table.Column<decimal>(nullable: false),
                    Comision = table.Column<decimal>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: true),
                    Published = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Imagen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCMR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Privilege",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilege", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Desc = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Published = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoCodes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Reporters",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    userid = table.Column<string>(nullable: true),
                    Reported = table.Column<DateTime>(nullable: false),
                    Error = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SecondHand",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    PrecioCompra = table.Column<decimal>(nullable: false),
                    PrecioVenta = table.Column<decimal>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Enviado = table.Column<bool>(nullable: false),
                    Calificacion = table.Column<int>(nullable: false),
                    Entregado = table.Column<bool>(nullable: false),
                    Posted = table.Column<DateTime>(nullable: false),
                    SellerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondHand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tempComponents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompID = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Subido = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Employeeid = table.Column<string>(nullable: true),
                    PrecioCompra = table.Column<decimal>(nullable: false),
                    PrecioVenta = table.Column<decimal>(nullable: false),
                    ComisionPay = table.Column<decimal>(nullable: false),
                    Ganancia = table.Column<decimal>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Categoryid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tempComponents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UsedPromos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    PromoCodeID = table.Column<string>(nullable: true),
                    UsedCode = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedPromos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    userid = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    INE = table.Column<string>(nullable: true),
                    ImagenINE = table.Column<string>(nullable: true),
                    Curp = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Registro = table.Column<DateTime>(nullable: false),
                    Calificacion = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Componente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Subido = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Employeeid = table.Column<string>(nullable: true),
                    PrecioCompra = table.Column<decimal>(nullable: false),
                    PrecioVenta = table.Column<decimal>(nullable: false),
                    ComisionPay = table.Column<decimal>(nullable: false),
                    Ganancia = table.Column<decimal>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Revision = table.Column<bool>(nullable: false),
                    Calificacion = table.Column<int>(nullable: false),
                    Categoryid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Componente_Category_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<decimal>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Published = table.Column<DateTime>(nullable: false),
                    employeeid = table.Column<string>(nullable: true),
                    Categoryid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.id);
                    table.ForeignKey(
                        name: "FK_Softwares_Category_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    INE = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Privilegeid = table.Column<int>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Cadena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employee_Privilege_Privilegeid",
                        column: x => x.Privilegeid,
                        principalTable: "Privilege",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orderid = table.Column<int>(nullable: false),
                    Userid = table.Column<string>(nullable: true),
                    PCid = table.Column<int>(nullable: false),
                    Compid = table.Column<int>(nullable: false),
                    Sofid = table.Column<int>(nullable: false),
                    SHid = table.Column<string>(nullable: true),
                    PCMRid = table.Column<int>(nullable: true),
                    secondHandid = table.Column<string>(nullable: true),
                    Componenteid = table.Column<int>(nullable: true),
                    Softwareid = table.Column<int>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    RefPago = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Componente_Componenteid",
                        column: x => x.Componenteid,
                        principalTable: "Componente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_PCMR_PCMRid",
                        column: x => x.PCMRid,
                        principalTable: "PCMR",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Softwares_Softwareid",
                        column: x => x.Softwareid,
                        principalTable: "Softwares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_SecondHand_secondHandid",
                        column: x => x.secondHandid,
                        principalTable: "SecondHand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "shoppingCartItems",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Componenteid = table.Column<int>(nullable: true),
                    PCMRid = table.Column<int>(nullable: true),
                    Softwareid = table.Column<int>(nullable: true),
                    SegundaManoid = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    ShoppingCartID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCartItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_Componente_Componenteid",
                        column: x => x.Componenteid,
                        principalTable: "Componente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_PCMR_PCMRid",
                        column: x => x.PCMRid,
                        principalTable: "PCMR",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_SecondHand_SegundaManoid",
                        column: x => x.SegundaManoid,
                        principalTable: "SecondHand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_Softwares_Softwareid",
                        column: x => x.Softwareid,
                        principalTable: "Softwares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tempOrders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordid = table.Column<int>(nullable: false),
                    userid = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Colonia = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Politicas = table.Column<bool>(nullable: false),
                    Entregado = table.Column<bool>(nullable: false),
                    MetodoPago = table.Column<string>(nullable: true),
                    Acreditado = table.Column<bool>(nullable: false),
                    Enviado = table.Column<bool>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Ordenado = table.Column<DateTime>(nullable: false),
                    EntregaEstimada = table.Column<DateTime>(nullable: false),
                    MetodoEnvio = table.Column<string>(nullable: true),
                    RefPago = table.Column<string>(nullable: true),
                    Devolucion = table.Column<bool>(nullable: false),
                    Cancelado = table.Column<bool>(nullable: false),
                    OrderDetailid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tempOrders", x => x.id);
                    table.ForeignKey(
                        name: "FK_tempOrders_OrderDetails_OrderDetailid",
                        column: x => x.OrderDetailid,
                        principalTable: "OrderDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Componente_Categoryid",
                table: "Componente",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Privilegeid",
                table: "Employee",
                column: "Privilegeid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Componenteid",
                table: "OrderDetails",
                column: "Componenteid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PCMRid",
                table: "OrderDetails",
                column: "PCMRid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Softwareid",
                table: "OrderDetails",
                column: "Softwareid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_secondHandid",
                table: "OrderDetails",
                column: "secondHandid");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_Componenteid",
                table: "shoppingCartItems",
                column: "Componenteid");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_PCMRid",
                table: "shoppingCartItems",
                column: "PCMRid");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_SegundaManoid",
                table: "shoppingCartItems",
                column: "SegundaManoid");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_Softwareid",
                table: "shoppingCartItems",
                column: "Softwareid");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_Categoryid",
                table: "Softwares",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_tempOrders_OrderDetailid",
                table: "tempOrders",
                column: "OrderDetailid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "DataEntity");

            migrationBuilder.DropTable(
                name: "Edit");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Entidad");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "Reporters");

            migrationBuilder.DropTable(
                name: "shoppingCartItems");

            migrationBuilder.DropTable(
                name: "tempComponents");

            migrationBuilder.DropTable(
                name: "tempOrders");

            migrationBuilder.DropTable(
                name: "UsedPromos");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Componente");

            migrationBuilder.DropTable(
                name: "PCMR");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "SecondHand");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
