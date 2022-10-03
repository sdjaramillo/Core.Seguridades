using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.Noticias;
using Core.Seguridades.Model.Transaccion.Request.Noticias;
using Core.Seguridades.Model.Transaccion.Response.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        [HttpPost]
        [Route("ObtenerListaNoticia")]
        [Produces(typeof(EstructuraBase<ObtenerListaNoticiaResponse>))]
        public IActionResult ObtenerListaNoticia([FromBody] string peticionNombreRed)
        {
            NoticiaTrx transaccion = this.GenerarTransaccion<NoticiaTrx>();
            transaccion.NombreRedRequest = peticionNombreRed;

            EstructuraBase<ObtenerListaNoticiaResponse> respuesta = this.ObtenerTodos<NoticiaTrx, ObtenerListaNoticiaResponse, ObtenerListaNoticiaIN>(
                new ObtenerListaNoticiaIN(),
                transaccion);
            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarNoticia")]
        [Produces(typeof(EstructuraBase<ActualizarNoticiaResponse>))]
        public IActionResult ActualizarNoticia([FromBody] NoticiaRequest noticia)
        {
            NoticiaTrx transaccion = this.GenerarTransaccion<NoticiaTrx>();
            transaccion.NoticiaRequest = noticia;

            EstructuraBase<ActualizarNoticiaResponse> respuesta = this.Actualizar<NoticiaTrx, ActualizarNoticiaResponse, ActualizarNoticiaIN>(
                new ActualizarNoticiaIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarNoticia")]
        [Produces(typeof(EstructuraBase<AgregarNoticiaResponse>))]
        public IActionResult AgregarNoticia([FromBody] NoticiaRequest noticia)
        {
            NoticiaTrx transaccion = this.GenerarTransaccion<NoticiaTrx>();
            transaccion.NoticiaRequest = noticia;

            EstructuraBase<AgregarNoticiaResponse> respuesta = this.Insertar<NoticiaTrx, AgregarNoticiaResponse, AgregarNoticiaIN>(
                new AgregarNoticiaIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarNoticia")]
        [Produces(typeof(EstructuraBase<EliminarNoticiaResponse>))]
        public IActionResult EliminarNoticia([FromBody] string noticia)
        {
            NoticiaTrx transaccion = this.GenerarTransaccion<NoticiaTrx>();
            transaccion.CodigoNoticia = noticia;

            EstructuraBase<EliminarNoticiaResponse> respuesta = this.Eliminar<NoticiaTrx, EliminarNoticiaResponse, EliminarNoticiaIN>(
                new EliminarNoticiaIN(),
                transaccion);

            return Ok(respuesta);
        }


    }
}
