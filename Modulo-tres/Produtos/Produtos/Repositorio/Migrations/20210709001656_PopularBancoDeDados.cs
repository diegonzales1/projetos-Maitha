using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class PopularBancoDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, CodigoDeBarras, DataCadastro, Ativo) VALUES ('Yakut', '1241SDF5SF78', GETDATE(), 'true');");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, CodigoDeBarras, DataCadastro, Ativo) VALUES ('Vassoura', '12345ASFD', GETDATE(), 'false');");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, CodigoDeBarras, DataCadastro, Ativo) VALUES ('Banana Nanica', '12345678', GETDATE(), 'true');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
