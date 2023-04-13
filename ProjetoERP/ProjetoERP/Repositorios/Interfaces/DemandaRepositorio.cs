using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;

namespace ProjetoErp.Repositorios.Interfaces
{
    public class DemandaRepositorio
    {
        private readonly ProjetoDBContext _dbContext;

        public DemandaRepositorio(ProjetoDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<List<DemandaModel>> BuscarDemandas()
        {
            return await _dbContext.Demandas.ToListAsync();
        }

        public async Task<DemandaModel> FazerDemanda(DemandaModel demanda)
        {

            ProdutoModel produto = await _dbContext.Produtos.FirstOrDefaultAsync(x => x.id_PD == demanda.id_PD);

            if (produto == null)
            {
                throw new Exception($"Produto para o ID:{demanda.id_PD} não foi encontrado");
            }

            if (demanda.quantidadeAdicionada > produto.estoqueMaximo_PD)
            {
                throw new Exception($"Estoque máximo ultrapassado");
            }

            produto.quantidadeEstoque_PD += demanda.quantidadeAdicionada;

             _dbContext.Produtos.Update(produto);
            await _dbContext.Demandas.AddAsync(demanda);

            await _dbContext.SaveChangesAsync();

            return demanda;
        }
    }
}
