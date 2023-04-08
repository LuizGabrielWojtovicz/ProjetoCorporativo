using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtosRepositorio;

        public ProdutosController(IProdutoRepositorio produtosRepositorio)
        {
            _produtosRepositorio = produtosRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarProdutos()
        {
            List<ProdutoModel> produtos = await _produtosRepositorio.BuscarProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> BuscarPorId(int id)
        {
            ProdutoModel produto = await _produtosRepositorio.BuscarPorId(id);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> Cadastrar([FromBody] ProdutoModel produtosModel)
        {
            ProdutoModel produto = await _produtosRepositorio.Adicionar(produtosModel);
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProdutoModel>> Atualizar([FromBody] ProdutoModel produtosModel, int id)
        {
            produtosModel.id_PD = id;
            ProdutoModel produto = await _produtosRepositorio.Atualizar(produtosModel, id);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdutoModel>> Apagar(int id)
        {
            bool apagado = await _produtosRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}

