using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Request.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Response.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuenteImagenesController : ControllerBase
    {
        [HttpPost]
        [Route("ObtenerListaFuenteImagen")]
        [Produces(typeof(EstructuraBase<ObtenerListaFuenteImagenResponse>))]
        public IActionResult ObtenerListaFuenteImagen([FromBody] ObtenerListaFuenteImagenRequest peticionImagen)
        {
            ImagenesTrx transaccion = this.GenerarTransaccion<ImagenesTrx>();
            transaccion.ImagenRequest = peticionImagen;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<ObtenerListaFuenteImagenResponse> respuesta = this.ObtenerTodos<ImagenesTrx, ObtenerListaFuenteImagenResponse, ObtenerListaFuenteImagenIN>(
                new ObtenerListaFuenteImagenIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarFuenteImagen")]
        [Produces(typeof(EstructuraBase<AgregarActualizarFuenteImagenResponse>))]
        public IActionResult AgregarFuenteImagen([FromBody] AgregarActualizarFuenteImagenRequest imagenNueva)
        {
            ImagenesTrx transaccion = this.GenerarTransaccion<ImagenesTrx>();
            transaccion.NuevaImagenRequest = imagenNueva;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<AgregarActualizarFuenteImagenResponse> respuesta = this.Insertar<ImagenesTrx, AgregarActualizarFuenteImagenResponse, AgregarFuenteImagenIN>(
                new AgregarFuenteImagenIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarFuenteImagen")]
        [Produces(typeof(EstructuraBase<AgregarActualizarFuenteImagenResponse>))]
        public IActionResult ActualizarFuenteImagen([FromBody] AgregarActualizarFuenteImagenRequest imagenRequest)
        {
            ImagenesTrx transaccion = this.GenerarTransaccion<ImagenesTrx>();
            transaccion.NuevaImagenRequest = imagenRequest;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<AgregarActualizarFuenteImagenResponse> respuesta = this.Actualizar<ImagenesTrx, AgregarActualizarFuenteImagenResponse, ActualizarFuenteImagenIN>(
                new ActualizarFuenteImagenIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarFuenteImagen")]
        [Produces(typeof(EstructuraBase<EliminarFuenteImagenResponse>))]
        public IActionResult EliminarFuenteImagen([FromBody] string imagenCodigo)
        {
            ImagenesTrx transaccion = this.GenerarTransaccion<ImagenesTrx>();
            //transaccion.Usuario.NombreRed = nombreRed;
            transaccion.ImagenCodigo = imagenCodigo;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<EliminarFuenteImagenResponse> respuesta = this.Eliminar<ImagenesTrx, EliminarFuenteImagenResponse, EliminarFuenteImagenIN>(
                new EliminarFuenteImagenIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
