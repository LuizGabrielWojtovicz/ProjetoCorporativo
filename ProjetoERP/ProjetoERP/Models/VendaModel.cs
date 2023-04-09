
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
using System.Text.Json.Serialization;

namespace ProjetoErp.Models
{
    public enum MetodoPagamento_VD { DINHEIRO, CREDITO, DEBITO, PIX}
    public enum Status_VD { ABERTO, CANCELADO, CONCLUIDO}
    public enum TipoVenda_VD { A_VISTA, A_PRAZO}
    public class VendaModel
    {
        //Primary Key VendasModel
        [Key]
        public int id_VD { get; set; }

        //Foreign Key ClientesModel
        [ForeignKey("ClientesModel")]
        public int id_CT { get; set; }

        //Foreign Key FuncionariosModel
        [ForeignKey("FuncionarioModel")]
        public int id_FN { get; set; }

        //Attributes
        public DateTime data_VD { get; set; }
        public Status_VD status_VD { get; set; }

        public double valorTotal_VD { get; set; }

        [JsonIgnore]
        public double desconto_VD { get; set; }
        public MetodoPagamento_VD metodoPagamento_VD { get; set; }
        public TipoVenda_VD tipoVenda_VD { get; set; }
        public string? descricao_VD { get; set; }
    }
}
