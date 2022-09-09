using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Request.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Response.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MenusController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("ObtenerListaMenuRol")]
        [Produces(typeof(EstructuraBase<ObtenerListaMenuRolResponse>))]
        public IActionResult ObtenerListaMenuRol([FromBody] ObtenerListaMenuRolRequest peticionMenu)
        {
            MenusTrx transaccion = this.GenerarTransaccion<MenusTrx>();
            transaccion.MenuRequest = peticionMenu;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<ObtenerListaMenuRolResponse> respuesta = this.ObtenerTodos<MenusTrx, ObtenerListaMenuRolResponse, ObtenerListaMenuRolIN>(
                new ObtenerListaMenuRolIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
