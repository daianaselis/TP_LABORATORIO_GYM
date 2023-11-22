using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IDCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaDeInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IDCliente);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IDEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Legajo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IDEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Cuota",
                columns: table => new
                {
                    IDCuota = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    FechaDePago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteIDCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpleadoIDEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuota", x => x.IDCuota);
                    table.ForeignKey(
                        name: "FK_Cuota_Clientes_ClienteIDCliente",
                        column: x => x.ClienteIDCliente,
                        principalTable: "Clientes",
                        principalColumn: "IDCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cuota_Empleados_EmpleadoIDEmpleado",
                        column: x => x.EmpleadoIDEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IDEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuota_ClienteIDCliente",
                table: "Cuota",
                column: "ClienteIDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cuota_EmpleadoIDEmpleado",
                table: "Cuota",
                column: "EmpleadoIDEmpleado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuota");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
