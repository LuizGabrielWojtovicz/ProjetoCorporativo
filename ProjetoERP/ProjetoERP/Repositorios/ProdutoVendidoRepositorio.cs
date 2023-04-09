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

        public async Task<bool> AdicionarProdutoNoCarrinho(int idProduto, int quantidade)     
        {
            ProdutoModel produto = await _dbContext.Produtos.FirstOrDefaultAsync(x => x.id_PD == idProduto);

            if (produto == null)
            {
                throw new Exception($"Produto para o ID:{idProduto} não foi encontrado");
            }

            if (quantidade > produto.quantidadeEstoque_PD)
            {
                throw new Exception($"Produto está em falta");
            }

            ProdutoVendidoModel produtoVendido = new ProdutoVendidoModel();

            produtoVendido.quantidade_CR = quantidade;
            produtoVendido.precoUnitario_PV = produto.precoVenda_PD;
            produtoVendido.nome_PV = produto.nome_PD;
            produtoVendido.id_PD = idProduto;
           
            // baixar estoque
            produto.quantidadeEstoque_PD -= produtoVendido.quantidade_CR;

             _dbContext.Produtos.Update(produto);
            await _dbContext.Carrinho.AddAsync(produtoVendido); 
            await _dbContext.SaveChangesAsync();

            return true;

        }

        public async Task<bool> RemoverProdutoDoCarrinho(int id)
        {
           
            ProdutoVendidoModel prod = await _dbContext.Carrinho.FirstOrDefaultAsync(x => x.id_PV == id);

            ProdutoModel produto = await _dbContext.Produtos.FirstOrDefaultAsync(x => x.id_PD == prod.id_PD);

            if (prod == null)
            {
                throw new Exception($"Produto para o ID:{id} não foi encontrado");
            }

            //restaurar estoque
            produto.quantidadeEstoque_PD += prod.quantidade_CR;

            _dbContext.Produtos.Update(produto);
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


        public async Task<bool> LimparCarrinho()
        {

            List<ProdutoVendidoModel> produtosCarrinho = await BuscarProdutos();

            if (produtosCarrinho == null)
            {
                throw new Exception($"O carrinho está vazio");
            }

            foreach (ProdutoVendidoModel produtoVendidoModel in produtosCarrinho)
            {
                _dbContext.Carrinho.Remove(produtoVendidoModel);
            }

            await _dbContext.SaveChangesAsync();

            return true;
        }


    }
}
