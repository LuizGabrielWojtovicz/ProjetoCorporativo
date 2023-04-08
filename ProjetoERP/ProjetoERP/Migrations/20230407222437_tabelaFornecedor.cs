using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoErp.Migrations
{
    /// <inheritdoc />
    public partial class tabelaFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    id_FN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enderecoLocal_FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroTelefone_FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enderecoEmail_FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentoCnpj_FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descricao_FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.id_FN);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
