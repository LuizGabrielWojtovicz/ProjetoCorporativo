using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoErp.Migrations
{
    /// <inheritdoc />
    public partial class tabelaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id_PD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_PD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantidadeEstoque_PD = table.Column<int>(type: "int", nullable: false),
                    estoqueMinimo_PD = table.Column<int>(type: "int", nullable: false),
                    unidadeMedida_PD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estoqueMaximo_PD = table.Column<int>(type: "int", nullable: false),
                    precoCusto_PD = table.Column<double>(type: "float", nullable: false),
                    precoVenda_PD = table.Column<double>(type: "float", nullable: false),
                    dataVencimento_PD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    importancia_PD = table.Column<int>(type: "int", nullable: false),
                    status_PD = table.Column<int>(type: "int", nullable: false),
                    descricao_PD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id_PD);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
