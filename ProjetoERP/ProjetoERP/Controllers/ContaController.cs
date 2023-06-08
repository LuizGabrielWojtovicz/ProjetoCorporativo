using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;
using ProjetoErp.Repositorios;
using System;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly ContaRepositorio _contaRepositorio;

        public ContaController(ContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ContaModel>>> BuscarContas()
        {
            List<ContaModel> contas = await _contaRepositorio.BuscarTodos();
            return Ok(contas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContaModel>> BuscarPorId(int id)
        {
            ContaModel conta = await _contaRepositorio.BuscarPorId(id);
            return Ok(conta);
        }

        [HttpGet("{codigo}")]
        public async Task<ActionResult<ContaModel>> BuscarPorCodigo(String codigo)
        {
            ContaModel conta = await _contaRepositorio.BuscarPorCodigo(codigo);
            return Ok(conta);
        }

        [HttpGet("/patrimonio")]
        public async Task<ActionResult<ContaModel>> BuscarContasPatrimonio()
        {
            List<TipoConta>? tipos = null;
            tipos.Add(TipoConta.ATIVO);
            tipos.Add(TipoConta.PASSIVO);
            List<ContaModel> contas = await _contaRepositorio.BuscarPorTipos(tipos);
            return Ok(contas);
        }

        [HttpGet("/resultado")]
        public async Task<ActionResult<ContaModel>> BuscarContasResultado()
        {
            List<TipoConta>? tipos = null;
            tipos.Add(TipoConta.DESPESA);
            tipos.Add(TipoConta.RECEITA);
            List<ContaModel> contas = await _contaRepositorio.BuscarPorTipos(tipos);
            return Ok(contas);
        }

        [HttpPost]
        public async Task<ActionResult<ContaModel>> CriarConta(ContaModel conta)
        {
            ContaModel novaConta = await _contaRepositorio.Adicionar(conta);
            return Ok(novaConta);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ContaModel>> AtualizarConta(int id, ContaModel conta)
        {
            ContaModel contaAtualizada = await _contaRepositorio.Atualizar(conta,id);
            return Ok(contaAtualizada);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ContaModel>> RemoverConta(int id)
        {
            bool removido = await _contaRepositorio.Apagar(id);
            return Ok(removido);
        }
    }
}
