using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM_VIII_TESTE.Migrations
{
    public partial class RelacionamentoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Telefone",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone",
                column: "PessoaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_PessoasTeste_PessoaId",
                table: "Telefone",
                column: "PessoaId",
                principalTable: "PessoasTeste",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_PessoasTeste_PessoaId",
                table: "Telefone");

            migrationBuilder.DropIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Telefone");
        }
    }
}
