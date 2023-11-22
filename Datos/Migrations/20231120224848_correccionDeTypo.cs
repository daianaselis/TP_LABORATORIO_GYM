using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    public partial class correccionDeTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuota_Clientes_ClienteIDCliente",
                table: "Cuota");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuota_Empleados_EmpleadoIDEmpleado",
                table: "Cuota");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuota",
                table: "Cuota");

            migrationBuilder.RenameTable(
                name: "Cuota",
                newName: "Cuotas");

            migrationBuilder.RenameIndex(
                name: "IX_Cuota_EmpleadoIDEmpleado",
                table: "Cuotas",
                newName: "IX_Cuotas_EmpleadoIDEmpleado");

            migrationBuilder.RenameIndex(
                name: "IX_Cuota_ClienteIDCliente",
                table: "Cuotas",
                newName: "IX_Cuotas_ClienteIDCliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuotas",
                table: "Cuotas",
                column: "IDCuota");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Clientes_ClienteIDCliente",
                table: "Cuotas",
                column: "ClienteIDCliente",
                principalTable: "Clientes",
                principalColumn: "IDCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Empleados_EmpleadoIDEmpleado",
                table: "Cuotas",
                column: "EmpleadoIDEmpleado",
                principalTable: "Empleados",
                principalColumn: "IDEmpleado",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Clientes_ClienteIDCliente",
                table: "Cuotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Empleados_EmpleadoIDEmpleado",
                table: "Cuotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuotas",
                table: "Cuotas");

            migrationBuilder.RenameTable(
                name: "Cuotas",
                newName: "Cuota");

            migrationBuilder.RenameIndex(
                name: "IX_Cuotas_EmpleadoIDEmpleado",
                table: "Cuota",
                newName: "IX_Cuota_EmpleadoIDEmpleado");

            migrationBuilder.RenameIndex(
                name: "IX_Cuotas_ClienteIDCliente",
                table: "Cuota",
                newName: "IX_Cuota_ClienteIDCliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuota",
                table: "Cuota",
                column: "IDCuota");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuota_Clientes_ClienteIDCliente",
                table: "Cuota",
                column: "ClienteIDCliente",
                principalTable: "Clientes",
                principalColumn: "IDCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuota_Empleados_EmpleadoIDEmpleado",
                table: "Cuota",
                column: "EmpleadoIDEmpleado",
                principalTable: "Empleados",
                principalColumn: "IDEmpleado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
