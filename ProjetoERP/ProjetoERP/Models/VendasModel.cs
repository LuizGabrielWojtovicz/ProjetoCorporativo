
/*
*MT <=> MATERIAIS
*PD <=> PRODUTOS
*VD <=> VENDAS
*CT <=> CLIENTES
*FN <=> FUNCIONARIOS
*PV <=> PRODUTOS VENDIDOS
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoErp.Models
{
    public enum MetodoPagamento_VD { DINHEIRO, CREDITO, DEBITO, PIX}
    public enum Status_VD { ABERTO, CANCELADO, CONCLUIDO}
    public enum TipoVenda_VD { A_VISTA, A_PRAZO}
    public class VendasModel
    {
        //Primary Key VendasModel
        [Key]
        public int id_VD { get; set; }

        //Foreign Key ClientesModel
        [ForeignKey("ClientesModel")]
        public int id_CT { get; set; }

        //Foreign Key FuncionariosModel
        [ForeignKey("FuncionariosModel")]
        public int id_FN { get; set; }

        //Attributes
        public List<ProdutosVendidosModel>? produtosVendidos { get; set; }
        public DateTime data_VD { get; set; }
        public DateTime dataPagamento_VD { get; set; }
        public Status_VD status_VD { get; set; }
        public double valorTotal_VD { get; set; }
        public double desconto_VD { get; set; }
        public MetodoPagamento_VD metodoPagamento_VD { get; set; }
        public TipoVenda_VD tipoVenda_VD { get; set; }
        public string? descricao_VD { get; set; }
    }
}
