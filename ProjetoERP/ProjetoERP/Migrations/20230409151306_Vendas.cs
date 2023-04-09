using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoErp.Migrations
{
    /// <inheritdoc />
    public partial class Vendas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    id_PV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_PV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantidade_CR = table.Column<int>(type: "int", nullable: false),
                    precoUnitario_PV = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.id_PV);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    id_VD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_CT = table.Column<int>(type: "int", nullable: false),
                    id_FN = table.Column<int>(type: "int", nullable: false),
                    data_VD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status_VD = table.Column<int>(type: "int", nullable: false),
                    valorTotal_VD = table.Column<double>(type: "float", nullable: false),
                    desconto_VD = table.Column<double>(type: "float", nullable: false),
                    metodoPagamento_VD = table.Column<int>(type: "int", nullable: false),
                    tipoVenda_VD = table.Column<int>(type: "int", nullable: false),
                    descricao_VD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.id_VD);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
