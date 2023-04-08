using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
*MT <=> MATERIAIS
*PD <=> PRODUTOS
*VD <=> VENDAS
*CT <=> CLIENTES
*FN <=> FUNCIONARIOS
*PV <=> PRODUTOS VENDIDOS
*/

namespace ProjetoErp.Models
{
    public class ProdutoVendidoModel
    {
        //Primary Key ProdutosVendidosModel
        [Key]
        public int id_PV { get; set; }

        public int id_PD { get; set; }

        public string nome_PV { get; set; }

        //Attributes
        public int quantidade_CR { get; set; }

        public double precoUnitario_PV { get; set; }

    }
}
