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
        [HttpPost]
        [Route("ObtenerListaMenuRol")]
        [Produces(typeof(EstructuraBase<ObtenerListaMenuRolResponse>))]
        public IActionResult ObtenerListaMenuRol([FromBody] ObtenerListaMenuRolRequest peticionMenu)
        {
            MenusTrx transaccion = this.GenerarTransaccion<MenusTrx>();
            transaccion.MenuRequest = peticionMenu;

            EstructuraBase<ObtenerListaMenuRolResponse> respuesta = this.ObtenerTodos<MenusTrx, ObtenerListaMenuRolResponse, ObtenerListaMenuRolIN>(
                new ObtenerListaMenuRolIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ObtenerLogoEmpresa")]
        [Produces(typeof(EstructuraBase<ObtenerLogoEmpresaResponse>))]
        public IActionResult ObtenerLogoEmpresa([FromBody] string peticionLogo)
        {
            MenusTrx transaccion = this.GenerarTransaccion<MenusTrx>();
            transaccion.NombreRed = peticionLogo;

            EstructuraBase<ObtenerLogoEmpresaResponse> respuesta = this.Obtener<MenusTrx, ObtenerLogoEmpresaResponse, ObtenerLogoEmpresaIN>(
                new ObtenerLogoEmpresaIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
