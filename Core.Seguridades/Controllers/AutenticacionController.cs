using Core.Common.Model.General;
using Core.Common.Util.Helper;
using Core.Seguridades.BusinessLogic.Internal.Autenticacion;
using Core.Seguridades.Model.Transaccion.Request.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        [HttpPost]
        [Route("AutenticarUsuario")]
        [Produces(typeof(EstructuraBase<AutenticarActiveDirectoryResponse>))]
        public IActionResult AutenticarUsuario([FromBody] AutenticarActiveDirectoryRequest autenticacion)
        {
            AutenticacionTrx transaccion = this.GenerarTransaccion<AutenticacionTrx>();
            transaccion.UsuarioAutenticacionRequest = autenticacion;

            EstructuraBase<AutenticarActiveDirectoryResponse> respuesta = this.ProcesarTransaccion<AutenticacionTrx, AutenticarActiveDirectoryResponse, AutenticarActiveDirectoryIN>(
                new AutenticarActiveDirectoryIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
