using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorController(IFornecedorRepositorio fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<FornecedorModel>>> BuscarFornecedores()
        {
            List<FornecedorModel> fornecedores = await _fornecedorRepositorio.BuscarFornecedores();
            return Ok(fornecedores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedorModel>> BuscarPorId(int id)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.BuscarPorId(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }

        [HttpPost]
        public async Task<ActionResult<FornecedorModel>> Cadastrar([FromBody] FornecedorModel fornecedorModel)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.Adicionar(fornecedorModel);
            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<FornecedorModel>> Atualizar([FromBody] FornecedorModel fornecedorModel, int id)
        {
            fornecedorModel.id_FN = id;
            FornecedorModel fornecedor = await _fornecedorRepositorio.Atualizar(fornecedorModel, id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Apagar(int id)
        {
            bool apagado = await _fornecedorRepositorio.Apagar(id);
            if (!apagado)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
