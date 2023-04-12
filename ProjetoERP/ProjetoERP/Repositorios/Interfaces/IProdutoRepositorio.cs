using ProjetoErp.Models;

namespace ProjetoErp.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<List<ProdutoModel>> BuscarProdutos();

        Task<ProdutoModel> BuscarPorId(int id);

        Task<ProdutoModel> Adicionar(ProdutoModel produtoModel);

        Task<ProdutoModel> AtualizarQuantidadeProduto(ProdutoQuantidadeModel produtoModel);

        Task<ProdutoModel> Atualizar(ProdutoModel produtoModel, int id);

        Task<bool> Apagar(int id);
    }
}
