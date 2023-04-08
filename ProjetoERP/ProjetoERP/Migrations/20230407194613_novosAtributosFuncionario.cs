using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoErp.Migrations
{
    /// <inheritdoc />
    public partial class novosAtributosFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "anoContratacao_FN",
                table: "Funcionarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargo_FN",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "documentoCpf_FN",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "enderecoEmail_FN",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "enderecoLocal_FN",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numeroTelefone_FN",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "salario_FN",
                table: "Funcionarios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anoContratacao_FN",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "cargo_FN",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "documentoCpf_FN",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "enderecoEmail_FN",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "enderecoLocal_FN",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "numeroTelefone_FN",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "salario_FN",
                table: "Funcionarios");
        }
    }
}
