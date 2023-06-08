using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.dtos;
using ProjetoErp.Models;
using ProjetoErp.Services;

namespace ProjetoErp.Repositorios
{
    public class LancamentoRepositorio
    {

        private readonly ProjetoDBContext _dbContext;
        private ContaRepositorio contaRepositorio;

        public LancamentoRepositorio(ProjetoDBContext dbContext)
        {
            _dbContext = _dbContext;
        }

        public async Task<LancamentoDTO> Lancar(int idOrigem, TipoLancamento tipoOrigem, int idDestino, TipoLancamento tipoDestino, double valor)
        {
            LancamentoDTO lancamentoDTO = new LancamentoDTO();

            ContaModel contaOrigem = await contaRepositorio.BuscarPorId(idOrigem);
            ContaModel contaDestino = await contaRepositorio.BuscarPorId(idOrigem);

            LancamentoContabil lancamentoOrigem = new LancamentoContabil();
            lancamentoOrigem.conta = contaOrigem;
            lancamentoOrigem.valor = valor;
            lancamentoOrigem.tipo = tipoOrigem;
            contaOrigem.lancamentos.Add(lancamentoOrigem);
            await _dbContext.Lancamentos.AddAsync(lancamentoOrigem);
            await _dbContext.SaveChangesAsync();

            lancamentoDTO.setLancamentoOrigem(lancamentoOrigem);

            LancamentoContabil lancamentoDestino = new LancamentoContabil();
            lancamentoDestino.conta = contaDestino;
            lancamentoDestino.valor = valor;
            lancamentoDestino.tipo = tipoDestino;
            contaDestino.lancamentos.Add(lancamentoDestino);
            await _dbContext.Lancamentos.AddAsync(lancamentoDestino);
            await _dbContext.SaveChangesAsync();

            lancamentoDTO.setLancamentoDestino(lancamentoDestino);

            return lancamentoDTO;
        }
    }
}