using ProjetoErp.Models;

namespace ProjetoErp.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> BuscarTodos();

        Task<ClienteModel> BuscarPorId(int id);

        Task<ClienteModel> Adicionar(Object obj);

        Task<ClienteModel> Atualizar(Object obj, int id);

        Task<bool> Apagar(int id);

    }
}
