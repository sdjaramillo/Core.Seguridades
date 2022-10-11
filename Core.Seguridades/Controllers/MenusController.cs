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

        [HttpPost]
        [Route("ObtenerListaPermisosMenu")]
        [Produces(typeof(EstructuraBase<ObtenerListaPermisosMenuResponse>))]
        public IActionResult ObtenerListaPermisosMenu()
        {
            MenusTrx transaccion = this.GenerarTransaccion<MenusTrx>();

            EstructuraBase<ObtenerListaPermisosMenuResponse> respuesta = this.ObtenerTodos<MenusTrx, ObtenerListaPermisosMenuResponse, ObtenerListaPermisosMenuIN>(
                new ObtenerListaPermisosMenuIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarPermisoMenu")]
        [Produces(typeof(EstructuraBase<AgregarPermisoMenuResponse>))]
        public IActionResult AgregarPermisoMenu([FromBody] PermisoMenuRequest PermisoMenuNueva)
        {
            MenusTrx transaccion = this.GenerarTransaccion<MenusTrx>();
            transaccion.PermisoMenuRequest = PermisoMenuNueva;

            EstructuraBase<AgregarPermisoMenuResponse> respuesta = this.Insertar<MenusTrx, AgregarPermisoMenuResponse, AgregarPermisoMenuIN>(
                new AgregarPermisoMenuIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarPermisoMenu")]
        [Produces(typeof(EstructuraBase<EliminarPermisoMenuResponse>))]
        public IActionResult EliminarPermisoMenu([FromBody] EliminarPermisoMenuRequest eliminarPermisoMenu )
        {
            MenusTrx transaccion = this.GenerarTransaccion<MenusTrx>();
            transaccion.EliminarPermisoMenuRequest = eliminarPermisoMenu;

            EstructuraBase<EliminarPermisoMenuResponse> respuesta = this.Eliminar<MenusTrx, EliminarPermisoMenuResponse, EliminarPermisoMenuIN>(
                new EliminarPermisoMenuIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
