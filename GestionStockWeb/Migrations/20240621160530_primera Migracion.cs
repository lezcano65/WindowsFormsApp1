using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionStockWeb.Migrations
{
    /// <inheritdoc />
    public partial class primeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HashU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilitado = table.Column<bool>(type: "bit", nullable: true),
                    CategoriaFk = table.Column<int>(type: "int", nullable: true),
                    CantidadP = table.Column<int>(type: "int", nullable: true),
                    CategoriaFkNavigationCategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaFkNavigationCategoriaId",
                        column: x => x.CategoriaFkNavigationCategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId");
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaC = table.Column<DateOnly>(type: "date", nullable: true),
                    CantidadC = table.Column<int>(type: "int", nullable: true),
                    ProductoFk = table.Column<int>(type: "int", nullable: true),
                    UsuarioFk = table.Column<int>(type: "int", nullable: true),
                    ProductoFkNavigationProductoId = table.Column<int>(type: "int", nullable: true),
                    UsuarioFkNavigationUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Productos_ProductoFkNavigationProductoId",
                        column: x => x.ProductoFkNavigationProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                    table.ForeignKey(
                        name: "FK_Compras_Usuario_UsuarioFkNavigationUsuarioId",
                        column: x => x.UsuarioFkNavigationUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaV = table.Column<DateOnly>(type: "date", nullable: true),
                    CantidadV = table.Column<int>(type: "int", nullable: true),
                    ProductoFk = table.Column<int>(type: "int", nullable: true),
                    UsuarioFk = table.Column<int>(type: "int", nullable: true),
                    ProductoFkNavigationProductoId = table.Column<int>(type: "int", nullable: true),
                    UsuarioFkNavigationUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_ProductoFkNavigationProductoId",
                        column: x => x.ProductoFkNavigationProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                    table.ForeignKey(
                        name: "FK_Ventas_Usuario_UsuarioFkNavigationUsuarioId",
                        column: x => x.UsuarioFkNavigationUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProductoFkNavigationProductoId",
                table: "Compras",
                column: "ProductoFkNavigationProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioFkNavigationUsuarioId",
                table: "Compras",
                column: "UsuarioFkNavigationUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaFkNavigationCategoriaId",
                table: "Productos",
                column: "CategoriaFkNavigationCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductoFkNavigationProductoId",
                table: "Ventas",
                column: "ProductoFkNavigationProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_UsuarioFkNavigationUsuarioId",
                table: "Ventas",
                column: "UsuarioFkNavigationUsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
