using Microsoft.AspNetCore.Mvc;

using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteModel>>> BuscarClientes()
        {
            List<ClienteModel> clientes = await _clienteRepositorio.BuscarTodos();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteModel>> BuscarPorId(int id)
        {
            ClienteModel cliente = await _clienteRepositorio.BuscarPorId(id);

            if (cliente == null)
            {
                throw new Exception($"Cliente para o ID:{id} não foi encontrado");
            }

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult<ClienteModel>> Cadastrar([FromBody] ClienteModel clienteModel)
        {
            ClienteModel cliente = await _clienteRepositorio.Adicionar(clienteModel);
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ClienteModel>> Atualizar([FromBody] ClienteModel clienteModel, int id)
        {
            clienteModel.id_CT = id;
            ClienteModel cliente = await _clienteRepositorio.Atualizar(clienteModel, id);

            if (cliente == null)
            {
                throw new Exception($"Cliente para o ID:{id} não foi encontrado");
            }

            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ClienteModel>> Apagar(int id)
        {
            bool apagado = await _clienteRepositorio.Apagar(id);

            if (!apagado)
            {
                throw new Exception($"Cliente para o ID:{id} não foi encontrado");
            }

            return Ok(apagado);
        }
    }
}
