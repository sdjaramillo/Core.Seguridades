using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.Preguntas;
using Core.Seguridades.Model.Transaccion.Response.Preguntas;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreguntasController : ControllerBase
    {
        [HttpPost]
        [Route("ObtenerListaPreguntas")]
        [Produces(typeof(EstructuraBase<ObtenerListaPreguntaResponse>))]

        public IActionResult ObtenerListaPregunta([FromBody] string peticionNombreRed)
        {
            PreguntaTrx transaccion = this.GenerarTransaccion<PreguntaTrx>();
            transaccion.NombreRedRequest = peticionNombreRed;

            EstructuraBase<ObtenerListaPreguntaResponse> respuesta = this.ObtenerTodos<PreguntaTrx, ObtenerListaPreguntaResponse, ObtenerListaPreguntaIN>(
                new ObtenerListaPreguntaIN(),
                transaccion);
            return Ok(respuesta);
        }
    }
}

