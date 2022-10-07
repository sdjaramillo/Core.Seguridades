using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.Permisos;
using Core.Seguridades.Model.Transaccion.Request.Permisos;
using Core.Seguridades.Model.Transaccion.Response.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisosController : ControllerBase
    {
        [HttpPost]
        [Route("ObtenerListaPermiso")]
        [Produces(typeof(EstructuraBase<ObtenerListaPermisoResponse>))]
        public IActionResult ObtenerListaPermiso([FromBody] string codigoProyecto)
        {
            PermisoTrx transaccion = this.GenerarTransaccion<PermisoTrx>();
            transaccion.ProyectoCodigo = codigoProyecto;

            EstructuraBase<ObtenerListaPermisoResponse> respuesta = this.ObtenerTodos<PermisoTrx, ObtenerListaPermisoResponse, ObtenerListaPermisoIN>(
                new ObtenerListaPermisoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarPermiso")]
        [Produces(typeof(EstructuraBase<AgregarPermisoResponse>))]
        public IActionResult AgregarPermiso([FromBody] PermisoRequest PermisoNuevo)
        {
            PermisoTrx transaccion = this.GenerarTransaccion<PermisoTrx>();
            transaccion.PermisoRequest = PermisoNuevo;

            EstructuraBase<AgregarPermisoResponse> respuesta = this.Insertar<PermisoTrx, AgregarPermisoResponse, AgregarPermisoIN>(
                new AgregarPermisoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarPermiso")]
        [Produces(typeof(EstructuraBase<ActualizarPermisoResponse>))]
        public IActionResult ActualizarPermiso([FromBody] PermisoRequest PermisoRequest)
        {
            PermisoTrx transaccion = this.GenerarTransaccion<PermisoTrx>();
            transaccion.PermisoRequest = PermisoRequest;

            EstructuraBase<ActualizarPermisoResponse> respuesta = this.Actualizar<PermisoTrx, ActualizarPermisoResponse, ActualizarPermisoIN>(
                new ActualizarPermisoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarPermiso")]
        [Produces(typeof(EstructuraBase<EliminarPermisoResponse>))]
        public IActionResult EliminarPermiso([FromBody] string codigoPermiso)
        {
            PermisoTrx transaccion = this.GenerarTransaccion<PermisoTrx>();
            transaccion.PermisoRequest.Codigo = codigoPermiso;

            EstructuraBase<EliminarPermisoResponse> respuesta = this.Eliminar<PermisoTrx, EliminarPermisoResponse, EliminarPermisoIN>(
                new EliminarPermisoIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
