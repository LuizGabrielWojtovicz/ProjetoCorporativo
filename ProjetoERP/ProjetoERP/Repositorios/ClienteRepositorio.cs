using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    { 

        private readonly ProjetoDBContext _dbContext;

        public ClienteRepositorio(ProjetoDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<ClienteModel> Adicionar(object obj)
        {
            ClienteModel clienteModel = (ClienteModel)obj;
            await _dbContext.Clientes.AddAsync(clienteModel);
            await _dbContext.SaveChangesAsync();

            return clienteModel;
        }

        public async Task<ClienteModel> Atualizar(object obj, int id)
        {
            ClienteModel cliente = (ClienteModel)obj;
            ClienteModel clin= await BuscarPorId(id);

            if (clin == null)
            {
                throw new Exception($"Cliente para o ID:{id} não foi encontrado");
            }

            clin.nome_CT = cliente.nome_CT;
            clin.enderecoLocal_CT = cliente.enderecoLocal_CT;
            clin.numeroTelefone_CT =cliente.numeroTelefone_CT;
            clin.enderecoLocal_CT = cliente.enderecoEmail_CT;

            _dbContext.Clientes.Update(clin);
            await _dbContext.SaveChangesAsync();

            return clin;

        }

        public async Task<bool> Apagar(int id)
        {
            ClienteModel clin = await BuscarPorId(id);
            await _dbContext.SaveChangesAsync();

            if (clin == null)
            {
                throw new Exception($"Cliente para o ID:{id} não foi encontrado");
            }

            _dbContext.Clientes.Remove(clin);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ClienteModel> BuscarPorId(int id)
        {
            return await _dbContext.Clientes.FirstOrDefaultAsync(x => x.id_CT == id);
        }

        public async Task<List<ClienteModel>> BuscarTodos()
        {
            return await _dbContext.Clientes.ToListAsync();
        }

       
    }
}
       
    


    

