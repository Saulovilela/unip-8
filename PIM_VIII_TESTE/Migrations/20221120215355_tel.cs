using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM_VIII_TESTE.Migrations
{
    public partial class tel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoTeste_PessoasTeste_PessoaId",
                table: "EnderecoTeste");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PessoasTeste",
                table: "PessoasTeste");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnderecoTeste",
                table: "EnderecoTeste");

            migrationBuilder.DropColumn(
                name: "telefone",
                table: "PessoasTeste");

            migrationBuilder.RenameTable(
                name: "PessoasTeste",
                newName: "Pessoas");

            migrationBuilder.RenameTable(
                name: "EnderecoTeste",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoTeste_PessoaId",
                table: "Endereco",
                newName: "IX_Endereco_PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoas_PessoaId",
                table: "Endereco",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoas_PessoaId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "PessoasTeste");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "EnderecoTeste");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_PessoaId",
                table: "EnderecoTeste",
                newName: "IX_EnderecoTeste_PessoaId");

            migrationBuilder.AddColumn<long>(
                name: "telefone",
                table: "PessoasTeste",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PessoasTeste",
                table: "PessoasTeste",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecoTeste",
                table: "EnderecoTeste",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefone_PessoasTeste_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "PessoasTeste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoTeste_PessoasTeste_PessoaId",
                table: "EnderecoTeste",
                column: "PessoaId",
                principalTable: "PessoasTeste",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
