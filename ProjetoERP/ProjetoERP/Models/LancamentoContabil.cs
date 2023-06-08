
namespace ProjetoErp.Models
{
    public enum TipoLancamento {DEBITO,CREDITO}
    public class LancamentoContabil
    {
        public int id { get; set; }

        public ContaModel conta { get; set; }

        public double valor { get; set; }

        public TipoLancamento tipo { get; set; }
}
}
