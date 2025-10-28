using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Calificacion = table.Column<decimal>(type: "decimal(3,2)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Cuit = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    TipoIngrediente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FotoPerfil = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(8,3)", nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Origen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LimiteBajoStock = table.Column<decimal>(type: "decimal(8,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Penalizacion = table.Column<decimal>(type: "decimal(5,2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Cuil = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HorasTrabajadas = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    PrecioPorHora = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Sueldo = table.Column<decimal>(type: "decimal(10,2)", nullable: false, computedColumnSql: "[HorasTrabajadas] * [PrecioPorHora]"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductoIngrediente",
                columns: table => new
                {
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoIngrediente", x => new { x.IngredienteId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_ProductoIngrediente_Ingredientes_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoIngrediente_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Estado = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    FechaHoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaHoraFinEstimada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "PedidoProducto",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProducto", x => new { x.PedidoId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_PedidoProducto_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProducto_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Cuil",
                table: "Empleados",
                column: "Cuil",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_UsuarioId",
                table: "Empleados",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_ProveedorId",
                table: "Ingredientes",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProducto_ProductoId",
                table: "PedidoProducto",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpleadoId",
                table: "Pedidos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoIngrediente_ProductoId",
                table: "ProductoIngrediente",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Cuit",
                table: "Proveedores",
                column: "Cuit",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Username",
                table: "Usuarios",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoProducto");

            migrationBuilder.DropTable(
                name: "ProductoIngrediente");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
