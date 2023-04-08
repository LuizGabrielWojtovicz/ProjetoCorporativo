using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Repositorios
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
            private readonly ProjetoDBContext _dbContext;
            public FornecedorRepositorio(ProjetoDBContext dBContext)
            {
                _dbContext = dBContext;
            }
     
            public async Task<FornecedorModel> Adicionar(FornecedorModel fornecedor)
            {
                await _dbContext.Fornecedores.AddAsync(fornecedor);
                await _dbContext.SaveChangesAsync();

                return fornecedor;
            }

            public async Task<FornecedorModel> Atualizar(FornecedorModel fornecedor, int id)
            {
            FornecedorModel forn = await BuscarPorId(id);

                if (forn == null)
                {
                    throw new Exception($"Fornecedor para o ID:{id} não foi encontrado");
                }

              
                _dbContext.Fornecedores.Update(fornecedor);
                await _dbContext.SaveChangesAsync();

                return forn;

            }

            public async Task<bool> Apagar(int id)
            {
            FornecedorModel forn = await BuscarPorId(id);
                await _dbContext.SaveChangesAsync();

                if (forn == null)
                {
                    throw new Exception($"Fornecedor para o ID:{id} não foi encontrado");
                }

                _dbContext.Fornecedores.Remove(forn);
                await _dbContext.SaveChangesAsync();

                return true;
            }

            public async Task<FornecedorModel> BuscarPorId(int id)
            {
                return await _dbContext.Fornecedores.FirstOrDefaultAsync(x => x.id_FN == id);
            }

            public async Task<List<FornecedorModel>> BuscarFornecedores()
            {
                return await _dbContext.Fornecedores.ToListAsync();
            }
        }
}
