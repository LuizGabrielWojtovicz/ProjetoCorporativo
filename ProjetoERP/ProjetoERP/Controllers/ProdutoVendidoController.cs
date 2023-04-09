using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;
using ProjetoErp.Repositorios;

[Route("api/[controller]")]
[ApiController]
public class ProdutoVendidoController : ControllerBase
{
    private readonly ProdutoVendidoRepositorio _produtoVendidoRepositorio;

    public ProdutoVendidoController(ProdutoVendidoRepositorio produtoVendidoRepositorio)
    {
        _produtoVendidoRepositorio = produtoVendidoRepositorio;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProdutoVendidoModel>>> BuscarProdutosVendidos()
    {
        List<ProdutoVendidoModel> produtosVendidos = await _produtoVendidoRepositorio.BuscarProdutos();
        return Ok(produtosVendidos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProdutoVendidoModel>> BuscarPorId(int id)
    {
        ProdutoVendidoModel produtoVendido = await _produtoVendidoRepositorio.BuscarPorId(id);
        return Ok(produtoVendido);
    }

    [HttpPost("{idProduto}/{quantidade}")]
    public async Task<ActionResult<ProdutoVendidoModel>> AdicionarAoCarrinho(int idProduto, int quantidade)
    {
        bool adicionado = await _produtoVendidoRepositorio.AdicionarProdutoNoCarrinho(idProduto, quantidade);
        return Ok(adicionado);
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult<ProdutoVendidoModel>> RemoverDoCarrinho(int id)
    {
        bool apagado = await _produtoVendidoRepositorio.RemoverProdutoDoCarrinho(id);
        return Ok(apagado);
    }
}
