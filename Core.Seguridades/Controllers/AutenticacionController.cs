using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
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
        private readonly IConfiguration _configuration;
        public AutenticacionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("AutenticarUsuarioActiveDirectory")]
        [Produces(typeof(EstructuraBase<AutenticarActiveDirectoryResponse>))]
        public IActionResult AutenticarUsuarioActiveDirectory([FromBody] AutenticarActiveDirectoryRequest autenticacion)
        {
            AutenticacionTrx transaccion = this.GenerarTransaccion<AutenticacionTrx>();
            transaccion.UsuarioAutenticacionRequest = autenticacion;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<AutenticarActiveDirectoryResponse> respuesta = this.ProcesarTransaccionSimple<AutenticacionTrx, AutenticarActiveDirectoryResponse, AutenticarUsuarioActiveDirectoryIN>(
                new AutenticarUsuarioActiveDirectoryIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
