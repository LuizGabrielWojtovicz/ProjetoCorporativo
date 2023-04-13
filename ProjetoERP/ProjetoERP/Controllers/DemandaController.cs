using Microsoft.AspNetCore.Mvc;

using ProjetoErp.Models;
using ProjetoErp.Repositorios;
using ProjetoErp.Repositorios.Interfaces;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandaController : ControllerBase
    {
        private readonly DemandaRepositorio _demandaRepositorio;

        public DemandaController(DemandaRepositorio demandaRepositorio)
        {
            _demandaRepositorio = demandaRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<DemandaModel>>> BuscarDemandas()
        {
            List<DemandaModel> demandas = await _demandaRepositorio.BuscarDemandas();
            return Ok( demandas);
        }

        [HttpPost]
        public async Task<ActionResult<DemandaModel>> Cadastrar([FromBody] DemandaModel demandaModel)
        {
            DemandaModel demanda = await _demandaRepositorio.FazerDemanda(demandaModel);
            return Ok(demanda);
        }
    }
}
