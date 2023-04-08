using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        [HttpGet]
       
        public async Task<ActionResult<List<FuncionarioModel>>> BuscarFuncionarios()
        {
            List<FuncionarioModel> funcionarios = await _funcionarioRepositorio.BuscarTodos();
            return Ok(funcionarios);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FuncionarioModel>> BuscarPorId(int id)
        {
            FuncionarioModel funcionario = await _funcionarioRepositorio.BuscarPorId(id);
            return Ok(funcionario);

        }

        [HttpPost]

        public async Task<ActionResult<FuncionarioModel>> Cadastrar([FromBody] FuncionarioModel funcionarioModel)
        {
            FuncionarioModel funcionario = await _funcionarioRepositorio.Adicionar(funcionarioModel);
            return Ok(funcionario);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<FuncionarioModel>> Atualizar([FromBody] FuncionarioModel funcionarioModel, int id)
        {
            funcionarioModel.id_FN = id;
            FuncionarioModel funcionario = await _funcionarioRepositorio.Atualizar(funcionarioModel, id);
            return Ok(funcionario);

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<FuncionarioModel>> Apagar(int id)
        {
            bool apagado = await _funcionarioRepositorio.Apagar(id);
            return Ok(apagado);

        }

    }
}
