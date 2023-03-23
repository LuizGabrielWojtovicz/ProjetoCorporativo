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
    public class ProdutosVendidosModel
    {
        //Primary Key ProdutosVendidosModel
        [Key]
        public int id_PV { get; set; }

        //Attributes
        public int quantidade_PV { get; set; }

        //Foreign Key ProdutosModel
        [ForeignKey("ProdutosModel")]
        public int id_PD { get; set; }
    }
}
