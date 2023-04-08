using ProjetoErp.Models;

namespace ProjetoErp.Repositorios.Interfaces
{
    public interface IFuncionarioRepositorio
    {
        Task<List<FuncionarioModel>> BuscarTodos();

        Task<FuncionarioModel> BuscarPorId(int id);

        Task<FuncionarioModel> Adicionar(Object obj);

        Task<FuncionarioModel> Atualizar(Object obj, int id);

        Task<bool> Apagar(int id);
    }
}
