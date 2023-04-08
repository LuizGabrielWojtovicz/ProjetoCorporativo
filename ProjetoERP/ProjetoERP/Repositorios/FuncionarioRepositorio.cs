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

      
        public async Task<FuncionarioModel> Adicionar(object obj)
        {
            FuncionarioModel funcionarioModel = (FuncionarioModel)obj;
            await _dbContext.Funcionarios.AddAsync(funcionarioModel);
            await _dbContext.SaveChangesAsync();

            return funcionarioModel;
        }

        public async Task<FuncionarioModel> Atualizar(object obj, int id)
        {
            FuncionarioModel funcionario = (FuncionarioModel)obj;
            FuncionarioModel func = await BuscarPorId(id);

            if (func == null)
            {
                throw new Exception($"Funcionário para o ID:{id} não foi encontrado");
            }

            func.nome_FN = funcionario.nome_FN;
            func.enderecoLocal_FN = funcionario.enderecoLocal_FN;
            func.numeroTelefone_FN = funcionario.numeroTelefone_FN;
            func.enderecoEmail_FN = funcionario.enderecoEmail_FN;
            func.cargo_FN = funcionario.cargo_FN;
            func.anoContratacao_FN = funcionario.anoContratacao_FN;
            func.documentoCpf_FN = funcionario.documentoCpf_FN;
            func.salario_FN = funcionario.salario_FN;

            _dbContext.Funcionarios.Update(func);
            await _dbContext.SaveChangesAsync();

            return func;

        }

        public async Task<bool> Apagar(int id)
        {
            FuncionarioModel func = await BuscarPorId(id);
            await _dbContext.SaveChangesAsync();

            if (func == null)
            {
                throw new Exception($"Funcionário para o ID:{id} não foi encontrado");
            }

            _dbContext.Funcionarios.Remove(func);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<FuncionarioModel> BuscarPorId(int id)
        {
           return await _dbContext.Funcionarios.FirstOrDefaultAsync(x => x.id_FN == id);
        }

        public async Task<List<FuncionarioModel>> BuscarTodos()
        {
            return await _dbContext.Funcionarios.ToListAsync(); 
        }
    }
}
