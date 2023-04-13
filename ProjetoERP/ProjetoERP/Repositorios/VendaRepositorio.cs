using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;

namespace ProjetoErp.Repositorios
{
    public class VendaRepositorio
    {
        private readonly ProjetoDBContext _dbContext;
        private readonly ProdutoVendidoRepositorio produtoVendidoRepositorio;
        public VendaRepositorio(ProjetoDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<VendaModel> GerarVenda(VendaModel venda)
        {

            List < ProdutoVendidoModel > produtosCarrinho = await _dbContext.Carrinho.ToListAsync();

            foreach (ProdutoVendidoModel produtoVendidoModel in produtosCarrinho)
            {
              venda.valorTotal_VD += produtoVendidoModel.precoUnitario_PV * produtoVendidoModel.quantidade_CR;
            }

            if (venda.valorTotal_VD == 0)
            {
                throw new Exception($"O carrinho está vazio");
            }

            await _dbContext.Vendas.AddAsync(venda);
            await _dbContext.SaveChangesAsync();

           await LimparCarrinho();

            return venda;
        }

        public async Task<bool> LimparCarrinho()
        {

            List<ProdutoVendidoModel> produtosCarrinho = await _dbContext.Carrinho.ToListAsync();

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


        public async Task<List<VendaModel>> BuscarVendas()
        {
            return await _dbContext.Vendas.ToListAsync();
        }
    }
}
