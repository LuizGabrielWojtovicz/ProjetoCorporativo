
/*
*MT <=> MATERIAIS
*PD <=> PRODUTOS
*VD <=> VENDAS
*CT <=> CLIENTES
*FN <=> FUNCIONARIOS
*PV <=> PRODUTOS VENDIDOS
*/

using System.ComponentModel.DataAnnotations;

namespace ProjetoErp.Models
{
    public enum Importancia_PD { ALTA, MEDIA, BAIXA }
    public enum Status_PD { ATIVO, INATIVO, ABSOLETO }
    public class ProdutoModel
    {
        //Primary Key ProdutosModel
        [Key]
        public int id_PD { get; set; }

        //Attributes
        public string? nome_PD { get; set; }
        public int quantidadeEstoque_PD { get; set; }
        public int estoqueMinimo_PD { get; set; }
        public string? unidadeMedida_PD { get; set; }
        public int estoqueMaximo_PD { get; set; }
        public double precoCusto_PD { get; set; }
        public double precoVenda_PD { get; set; }
        public DateTime dataVencimento_PD { get; set; }
        public Importancia_PD importancia_PD { get; set; }
        public Status_PD status_PD { get; set; }
        public string? descricao_PD { get; set; }
    }

    public class ProdutoQuantidadeModel
    {
        public int id_PD { get; set; }
        public int quantidadeEstoque_PD { get; set; }
    }

}
