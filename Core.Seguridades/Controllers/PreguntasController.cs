using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.Preguntas;
using Core.Seguridades.Model.Transaccion.Request.Preguntas;
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
        [Route("ObtenerListaPregunta")]
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

        [HttpPut]
        [Route("ActualizarPregunta")]
        [Produces(typeof(EstructuraBase<ActualizarPreguntaResponse>))]
        public IActionResult ActualizarNoticia([FromBody] PreguntaRequest pregunta)
        {
            PreguntaTrx transaccion = this.GenerarTransaccion<PreguntaTrx>();
            transaccion.PreguntaRequest = pregunta;

            EstructuraBase<ActualizarPreguntaResponse> respuesta = this.Actualizar<PreguntaTrx, ActualizarPreguntaResponse, ActualizarPreguntaIN>(
                new ActualizarPreguntaIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarPregunta")]
        [Produces(typeof(EstructuraBase<AgregarPreguntaResponse>))]
        public IActionResult AgregarNoticia([FromBody] PreguntaRequest pregunta)
        {
            PreguntaTrx transaccion = this.GenerarTransaccion<PreguntaTrx>();
            transaccion.PreguntaRequest = pregunta;

            EstructuraBase<AgregarPreguntaResponse> respuesta = this.Insertar<PreguntaTrx, AgregarPreguntaResponse, AgregarPreguntaIN>(
                new AgregarPreguntaIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarPregunta")]
        [Produces(typeof(EstructuraBase<EliminarPreguntaResponse>))]
        public IActionResult EliminarPregunta([FromBody] string pregunta)
        {
            PreguntaTrx transaccion = this.GenerarTransaccion<PreguntaTrx>();
            transaccion.CodigoPregunta = pregunta;

            EstructuraBase<EliminarPreguntaResponse> respuesta = this.Eliminar<PreguntaTrx, EliminarPreguntaResponse, EliminarPreguntaIN>(
                new EliminarPreguntaIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}

