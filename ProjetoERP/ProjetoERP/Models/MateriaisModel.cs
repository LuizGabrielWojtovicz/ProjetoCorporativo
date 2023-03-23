
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
    public enum Importancia_MT { ALTA, MEDIA, BAIXA}
    public enum Status_MT { ATIVO, INATIVO, ABSOLETO}
    public class MateriaisModel
    {
        //Primary Key MateriaisModel
        [Key]
        public int id_MT { get; set; }

        //Attributes
        public string? tipo_MT { get; set; }
        public int quantidadeEstoque_MT { get; set; }
        public string? unidadeMedida_MT { get; set; }
        public int quantidadeEstoqueMinimo_MT { get; set; }
        public int quantidadeEstoqueMaximo_MT { get; set; }
        public int tempoEntregaDia_MT { get; set; }
        public DateTime dataUltimaEntrega_MT { get; set; }
        public string? fornecedor_MT { get; set; }
        public double custoPadrao_MT { get; set; }
        public Importancia_MT importancia_MT { get;set; }
        public Status_MT status_MT { get; set; }
        public string? especificacoesTecnicas_MT { get; set; }
        public string? descricao_MT { get; set; }
    }
}
