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

            List < ProdutoVendidoModel > produtosCarrinho = await produtoVendidoRepositorio.BuscarProdutos();

            foreach(ProdutoVendidoModel produtoVendidoModel in produtosCarrinho)
            {
              venda.valorTotal_VD += produtoVendidoModel.precoUnitario_PV;
            }

            await _dbContext.Vendas.AddAsync(venda);

            return venda;
        }
    }
}
