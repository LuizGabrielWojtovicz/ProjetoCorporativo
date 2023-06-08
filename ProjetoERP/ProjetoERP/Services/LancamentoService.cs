using ProjetoErp.dtos;
using ProjetoErp.Models;
using ProjetoErp.Repositorios;

namespace ProjetoErp.Services
{
    public class LancamentoService
    {

        public ContaRepositorio contaRepositorio;
        public async LancamentoDTO  Lancar(int idOrigem, TipoLancamento tipoOrigem, int idDestino, TipoLancamento tipoDestino, double valor)
        {
            LancamentoDTO lancamento = new LancamentoDTO();

            ContaModel contaOrigem = await contaRepositorio.BuscarPorId(idOrigem);
            ContaModel contaDestino = await contaRepositorio.BuscarPorId(idOrigem);


        }
    }
}
