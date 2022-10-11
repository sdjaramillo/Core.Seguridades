using Core.Common.Model.Transaccion.Respuesta;
using Core.Seguridades.BusinessLogic.Internal.Autenticacion;
using Core.Seguridades.Model.Transaccion.Request.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using Core.Common.ProcessTemplate.Helper;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {

        [HttpPost]
        [Route("AutenticarUsuarioActiveDirectory")]
        [Produces(typeof(EstructuraBase<AutenticarActiveDirectoryResponse>))]
        public IActionResult AutenticarUsuarioActiveDirectory([FromBody] AutenticarActiveDirectoryRequest autenticacion)
        {
            AutenticacionTrx transaccion = this.GenerarTransaccion<AutenticacionTrx>();
            transaccion.UsuarioAutenticacionRequest = autenticacion;

            EstructuraBase<AutenticarActiveDirectoryResponse> respuesta = this.ProcesarTransaccionSimple<AutenticacionTrx, AutenticarActiveDirectoryResponse, AutenticarUsuarioActiveDirectoryIN>(
                new AutenticarUsuarioActiveDirectoryIN(),
                transaccion);

            return Ok(respuesta);
        }


        [HttpPost]
        [Route("GenerarToken")]
        [Produces(typeof(EstructuraBase<GenerarTokenResponse>))]
        public IActionResult GenerarToken([FromBody] GenerarTokenRequest request)
        {
            AutenticacionTrx transaccion = this.GenerarTransaccion<AutenticacionTrx>();

            transaccion.CredencialAcceso.Usuario = request.Nombre;
            transaccion.CredencialAcceso.Clave = request.Clave;

            EstructuraBase<GenerarTokenResponse> respuesta = this.ProcesarTransaccionSimple<AutenticacionTrx, GenerarTokenResponse, GenerarTokenIN>(
            new GenerarTokenIN(),
            transaccion);

            return Ok(respuesta);
        }
    }
}
