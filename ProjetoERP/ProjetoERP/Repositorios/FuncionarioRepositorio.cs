using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Repositorios
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly ProjetoDBContext _dbContext;
        public FuncionarioRepositorio(ProjetoDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<FuncionariosModel> Adicionar(FuncionariosModel funcionario)
        {
            await _dbContext.Funcionarios.AddAsync(funcionario);
            await  _dbContext.SaveChangesAsync();

            return funcionario;
        }

        public async Task<bool> Apagar(int id)
        {
            FuncionariosModel func = await BuscarPorId(id);
            await _dbContext.SaveChangesAsync();

            if (func == null)
            {
                throw new Exception($"Funcionário para o ID:{id} não foi encontrado");
            }

            _dbContext.Funcionarios.Remove(func);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<FuncionariosModel> Atualizar(FuncionariosModel funcionario, int id)
        {
           FuncionariosModel func =  await BuscarPorId(id);
            await _dbContext.SaveChangesAsync();

            if (func == null)
            {
                throw new Exception($"Funcionário para o ID:{id} não foi encontrado");
            }

            func.nome_FN = funcionario.nome_FN;

            _dbContext.Funcionarios.Update(func);
            await _dbContext.SaveChangesAsync();

            return func;
        }

        public async Task<List<FuncionariosModel>> BuscarFuncionarios()
        {
            return await _dbContext.Funcionarios.ToListAsync();
        }

        public async Task<FuncionariosModel> BuscarPorId(int id)
        {
           return await _dbContext.Funcionarios.FirstOrDefaultAsync(x => x.id_FN == id);
        }
    }
}
