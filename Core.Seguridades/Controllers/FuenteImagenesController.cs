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
        private readonly IConfiguration _configuration;
        public FuenteImagenesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
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
    }
}
