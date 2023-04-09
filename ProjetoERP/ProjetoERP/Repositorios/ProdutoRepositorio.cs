using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;
using System.Data;

namespace ProjetoErp.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ProjetoDBContext _dbContext;
        public ProdutoRepositorio(ProjetoDBContext dBContext) {
            _dbContext = dBContext;
        }
        
        public async Task<ProdutoModel> Adicionar(ProdutoModel produto)
        {
            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            var data = DateTime.Now;
            produto.dataVencimento_PD = data.AddYears(1);

            return produto;
        }

        public async Task<ProdutoModel> Atualizar(ProdutoModel produto, int id)
        {
            ProdutoModel prod = await BuscarPorId(id);

            if (prod == null)
            {
                throw new Exception($"Produto para o ID:{id} não foi encontrado");
            }

            prod.nome_PD = produto.nome_PD;
            prod.quantidadeEstoque_PD = produto.quantidadeEstoque_PD;
            prod.estoqueMaximo_PD = produto.estoqueMaximo_PD;
            prod.estoqueMinimo_PD = produto.estoqueMinimo_PD;
            prod.unidadeMedida_PD = produto.unidadeMedida_PD;
            prod.precoCusto_PD = produto.precoCusto_PD;
            prod.precoVenda_PD = produto.precoVenda_PD;
            prod.importancia_PD = produto.importancia_PD;
            prod.status_PD = produto.status_PD;
            prod.descricao_PD = produto.descricao_PD;
           

            _dbContext.Produtos.Update(produto);
            await _dbContext.SaveChangesAsync();

            return prod;

        }

        public async Task<bool> Apagar(int id)
        {
            ProdutoModel prod = await BuscarPorId(id);
           

            if (prod == null)
            {
                throw new Exception($"Produto para o ID:{id} não foi encontrado");
            }

            _dbContext.Produtos.Remove(prod);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ProdutoModel> BuscarPorId(int id)
        {
            return await _dbContext.Produtos.FirstOrDefaultAsync(x => x.id_PD == id);
        }

        public async Task<List<ProdutoModel>> BuscarProdutos()
        {
            return await _dbContext.Produtos.ToListAsync();
        }
    }
}
