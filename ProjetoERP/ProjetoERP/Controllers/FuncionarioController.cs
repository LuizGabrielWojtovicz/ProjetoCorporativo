using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoErp.Models;

namespace ProjetoErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<FuncionariosModel>> BuscarFuncionarios()     
        {
            return Ok();
        }

    }
}
