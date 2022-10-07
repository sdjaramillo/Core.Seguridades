using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.Aplicativos;
using Core.Seguridades.Model.Transaccion.Request.Aplicativos;
using Core.Seguridades.Model.Transaccion.Response.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;


namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AplicativosController : ControllerBase
    {
        
        [HttpPost]
        [Route("ObtenerListaAplicativos")]
        [Produces(typeof(EstructuraBase<ObtenerListaAplicativosResponse>))]
        public IActionResult ObtenerListaAplicativos([FromBody] string nombreRed)
        {
            AplicativosTrx transaccion = this.GenerarTransaccion<AplicativosTrx>();
            transaccion.NombreRed = nombreRed;

            EstructuraBase<ObtenerListaAplicativosResponse> respuesta = this.ObtenerTodos<AplicativosTrx, ObtenerListaAplicativosResponse, ObtenerListaAplicativosIN>(
                new ObtenerListaAplicativosIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarAplicativo")]
        [Produces(typeof(EstructuraBase<AgregarAplicativoResponse>))]
        public IActionResult AgregarAplicativo([FromBody] AplicativoRequest AplicativoNueva)
        {
            AplicativosTrx transaccion = this.GenerarTransaccion<AplicativosTrx>();
            transaccion.AplicativoRequest = AplicativoNueva;

            EstructuraBase<AgregarAplicativoResponse> respuesta = this.Insertar<AplicativosTrx, AgregarAplicativoResponse, AgregarAplicativoIN>(
                new AgregarAplicativoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarAplicativo")]
        [Produces(typeof(EstructuraBase<ActualizarAplicativoResponse>))]
        public IActionResult ActualizarAplicativo([FromBody] AplicativoRequest AplicativoRequest)
        {
            AplicativosTrx transaccion = this.GenerarTransaccion<AplicativosTrx>();
            transaccion.AplicativoRequest = AplicativoRequest;

            EstructuraBase<ActualizarAplicativoResponse> respuesta = this.Actualizar<AplicativosTrx, ActualizarAplicativoResponse, ActualizarAplicativoIN>(
                new ActualizarAplicativoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarAplicativo")]
        [Produces(typeof(EstructuraBase<EliminarAplicativoResponse>))]
        public IActionResult EliminarAplicativo([FromBody] string codigoAplicativo)
        {
            AplicativosTrx transaccion = this.GenerarTransaccion<AplicativosTrx>();
            transaccion.AplicativoRequest.Codigo = codigoAplicativo;

            EstructuraBase<EliminarAplicativoResponse> respuesta = this.Eliminar<AplicativosTrx, EliminarAplicativoResponse, EliminarAplicativoIN>(
                new EliminarAplicativoIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
