
namespace ProjetoErp.Models
{
    public enum TipoConta {ATIVO,PASSIVO,DESPESA,RECEITA}
    public class ContaModel
    {

        public int id { get; set; }
        public String? codigo { get; set; }

        public TipoConta tipo { get; set; }

        public String descricao { get; set; }

        public List<LancamentoContabil> lancamentos { get; set; }
    }
}

