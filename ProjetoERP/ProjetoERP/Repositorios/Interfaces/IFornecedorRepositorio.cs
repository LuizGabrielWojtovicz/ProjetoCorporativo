using ProjetoErp.Models;

namespace ProjetoErp.Repositorios.Interfaces
{
    public interface IFornecedorRepositorio
    {
        Task<List<FornecedorModel>> BuscarFornecedores();

        Task<FornecedorModel> BuscarPorId(int id);

        Task<FornecedorModel> Adicionar(FornecedorModel fornecedorModel);

        Task<FornecedorModel> Atualizar(FornecedorModel fornecedorModel, int id);

        Task<bool> Apagar(int id);
    }
}
