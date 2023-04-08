using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Repositorios
{
    public class ProdutoVendidoRepositorio
    {
        private readonly ProdutoRepositorio produtoRepositorio;
        private readonly ProjetoDBContext _dbContext;
        public ProdutoVendidoRepositorio(ProjetoDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<bool> AdicionarProdutoNoCarrinho(ProdutoVendidoModel produtoVendido)
          
        {
            ProdutoModel produto = await produtoRepositorio.BuscarPorId(produtoVendido.id_PD);

            if (produto == null)
            {
                throw new Exception($"Produto para o ID:{produtoVendido.id_PD} não foi encontrado");
            }

            if (produtoVendido.quantidade_CR > produto.quantidadeEstoque_PD)
            {
                throw new Exception($"Produto está em falta");
            }

            // baixar estoque

            

            await _dbContext.Carrinho.AddAsync(produtoVendido); 
            await _dbContext.SaveChangesAsync();

            return true;

        }

        public async Task<bool> RemoverProdutoDoCarrinho(int id)
        {

            ProdutoVendidoModel prod = await BuscarPorId(id);

            if (prod == null)
            {
                throw new Exception($"Produto para o ID:{id} não foi encontrado");
            }

            _dbContext.Carrinho.Remove(prod);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    
        public async Task<ProdutoVendidoModel> BuscarPorId(int id)
         {
        return await _dbContext.Carrinho.FirstOrDefaultAsync(x => x.id_PV == id);
           }

    public async Task<List<ProdutoVendidoModel>> BuscarProdutos()
        {
            return await _dbContext.Carrinho.ToListAsync();
        }

        //public async Task<CarrinhoModel> MostrarCarrinho()
        //{
        //    return await _dbContext.Carrinho.Include(x => x.Produtos).FirstOrDefaultAsync();
        //}
    }
}
