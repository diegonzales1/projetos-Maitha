using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId1",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_ClienteId1",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "NrConta",
                table: "Contas",
                newName: "NRConta");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Contas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "NRConta",
                table: "Contas",
                newName: "NrConta");

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Contas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Contas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ClienteId1",
                table: "Contas",
                column: "ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId1",
                table: "Contas",
                column: "ClienteId1",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
