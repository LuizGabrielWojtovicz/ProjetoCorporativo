using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;
using ProjetoErp.Repositorios;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly VendaRepositorio _vendaRepositorio;

        public VendaController(VendaRepositorio vendaRepositorio)
        {
            _vendaRepositorio = vendaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<VendaModel>>> BuscarVendas()
        {
            List<VendaModel> vendas = await _vendaRepositorio.BuscarVendas();
            return Ok(vendas);
        }

       
        [HttpPost]
        public async Task<ActionResult<VendaModel>> Cadastrar([FromBody] VendaModel vendaModel)
        {
            VendaModel venda = await _vendaRepositorio.GerarVenda(vendaModel);
            return Ok(venda);
        }

       
        //[HttpPost("{id}/produtos")]
        //public async Task<ActionResult<VendaModel>> AdicionarProduto(int id, [FromBody] ProdutoVendidoModel produto)
        //{
        //    VendaModel venda = await _vendaRepositorio.AdicionarProduto(id, produto);
        //    return Ok(venda);
        //}

        //[HttpDelete("{id}/produtos/{idProduto}")]
        //public async Task<ActionResult<VendaModel>> RemoverProduto(int id, int idProduto)
        //{
        //    VendaModel venda = await _vendaRepositorio.RemoverProduto(id, idProduto);
        //    return Ok(venda);
        //}
    }
}
