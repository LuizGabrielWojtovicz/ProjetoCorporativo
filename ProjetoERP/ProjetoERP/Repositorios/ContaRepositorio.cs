using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;

namespace ProjetoErp.Repositorios
{
    public class ContaRepositorio
    {

        private readonly ProjetoDBContext _dbContext;

        public ContaRepositorio(ProjetoDBContext dbContext)
        {
            _dbContext = _dbContext;
        }

        public async Task<ContaModel> Adicionar(object obj)
        {
            ContaModel contaModel = (ContaModel)obj;
            await _dbContext.Contas.AddAsync(contaModel);
            await _dbContext.SaveChangesAsync();

            return  contaModel;
        }

         public async Task<ContaModel> Atualizar(object obj, int id)
        {
            ContaModel conta = (ContaModel)obj;
            ContaModel cont = await BuscarPorId(id);

            if (cont == null)
            {
                throw new Exception($"Conta para o ID:{id} não foi encontrado");
            }

            cont.tipo = conta.tipo;
           

            _dbContext.Contas.Update(cont);
            await _dbContext.SaveChangesAsync();

            return cont;

        }

        public async Task<bool> Apagar(int id)
        {
            ContaModel conta = await BuscarPorId(id);
            await _dbContext.SaveChangesAsync();

            if (conta == null)
            {
                throw new Exception($"Conta para o ID:{id} não foi encontrado");
            }

            _dbContext.Contas.Remove(conta);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ContaModel> BuscarPorId(int id)
        {
            return await _dbContext.Contas.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<ContaModel>> BuscarTodos()
        {
            return await _dbContext.Contas.ToListAsync();
        }

        public async Task<ContaModel> BuscarPorCodigo(String codigo)
        {
            return await _dbContext.Contas.FirstOrDefaultAsync(x => x.codigo == codigo);
        }

        public async Task<List<ContaModel>> BuscarPorTipos(List<TipoConta> tipos)
        {
            return await _dbContext.Contas.Where(x => tipos.Contains(x.tipo)).ToListAsync();
        }
    }
}
