using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Request.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Response.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredencialesAccesosController : ControllerBase
    {
        [HttpPost]
        [Route("AgregarCredencialAcceso")]
        [Produces(typeof(EstructuraBase<AgregarCredencialAccesoResponse>))]
        public IActionResult AgregarCredencialAcceso([FromBody] AgregarCredencialRequest request)
        {
            CredencialAccesoTrx transaccion = this.GenerarTransaccion<CredencialAccesoTrx>();

            transaccion.CredencialAcceso.Usuario = request.Usuario;
            transaccion.CredencialAcceso.Clave = request.Clave;
            transaccion.CredencialAcceso.Cat_id_tipo = request.Categoria;
            transaccion.CredencialAcceso.EntidadId = request.Entidad;

            EstructuraBase<AgregarCredencialAccesoResponse> respuesta = this.Insertar<CredencialAccesoTrx, AgregarCredencialAccesoResponse, AgregarCredencialAccesoIN>(
            new AgregarCredencialAccesoIN(),
            transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ActualizarCredencialAcceso")]
        [Produces(typeof(EstructuraBase<ActualizarCredencialAccesoResponse>))]
        public IActionResult ActualizarCredencialAcceso([FromBody] ActualizarCredencialAccesoRequest request)
        {
            CredencialAccesoTrx transaccion = this.GenerarTransaccion<CredencialAccesoTrx>();

            transaccion.CredencialAcceso.Id = request.CredencialId;
            transaccion.CredencialAcceso.Usuario = request.Usuario;
            transaccion.CredencialAcceso.Clave = request.Clave;
            transaccion.CredencialAcceso.Cat_id_tipo = request.Categoria;
            transaccion.CredencialAcceso.EntidadId = request.EntidadId;

            EstructuraBase<ActualizarCredencialAccesoResponse> respuesta = this.Actualizar<CredencialAccesoTrx, ActualizarCredencialAccesoResponse, ActualizarCredencialAccesoIN>(
            new ActualizarCredencialAccesoIN(),
            transaccion);

            return Ok(respuesta);
        }
    }


}
