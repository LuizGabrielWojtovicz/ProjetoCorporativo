using ProjetoErp.Models;

namespace ProjetoErp.dtos
{
    public class LancamentoDTO
    {
        private LancamentoContabil lancamentoOrigem;
        private LancamentoContabil lancamentoDestino;

        public void setLancamentoOrigem(LancamentoContabil lancamentoOrigem)
        {
            this.lancamentoOrigem = lancamentoOrigem;
        }

        public void setLancamentoDestino(LancamentoContabil lancamentoDestino)
        {
            this.lancamentoDestino = lancamentoDestino;
        }
    }
}
