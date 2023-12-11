using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    public partial class BorradoEnCascada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Clientes_ClienteIDCliente",
                table: "Cuotas");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Clientes_ClienteIDCliente",
                table: "Cuotas",
                column: "ClienteIDCliente",
                principalTable: "Clientes",
                principalColumn: "IDCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Clientes_ClienteIDCliente",
                table: "Cuotas");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Clientes_ClienteIDCliente",
                table: "Cuotas",
                column: "ClienteIDCliente",
                principalTable: "Clientes",
                principalColumn: "IDCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
