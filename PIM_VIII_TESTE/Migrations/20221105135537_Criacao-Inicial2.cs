using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM_VIII_TESTE.Migrations
{
    public partial class CriacaoInicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "telefone",
                table: "PessoasTeste",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "telefone",
                table: "PessoasTeste",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
