using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoErp.Migrations
{
    /// <inheritdoc />
    public partial class tabelaDemanda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "id_FN",
            //    table: "Produtos");

            migrationBuilder.CreateTable(
                name: "Demandas",
                columns: table => new
                {
                    id_DM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_FN = table.Column<int>(type: "int", nullable: false),
                    id_PD = table.Column<int>(type: "int", nullable: false),
                    quantidadeAdicionada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demandas", x => x.id_DM);
                });
        }

        /// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Demandas");

        //    migrationBuilder.AddColumn<int>(
        //        name: "id_FN",
        //        table: "Produtos",
        //        type: "int",
        //        nullable: false,
        //        defaultValue: 0);
        //}
    }
}
