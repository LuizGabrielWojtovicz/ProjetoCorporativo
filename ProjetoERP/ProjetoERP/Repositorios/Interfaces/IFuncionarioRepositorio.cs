using ProjetoErp.Models;

namespace ProjetoErp.Repositorios.Interfaces
{
    public interface IFuncionarioRepositorio
    {
        Task<List<FuncionariosModel>> BuscarFuncionarios();

        Task<FuncionariosModel> BuscarPorId(int id);

        Task<FuncionariosModel> Adicionar(FuncionariosModel funcionario);

        Task<FuncionariosModel> Atualizar(FuncionariosModel funcionario, int id);

        Task<bool> Apagar(int id);
    }
}
