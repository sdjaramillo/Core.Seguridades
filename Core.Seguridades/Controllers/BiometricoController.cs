using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiometricoController : ControllerBase
    {
        [HttpPost]
        [Route("ObtenerListaRegistroBiometrico")]
        [Produces(typeof(EstructuraBase<ObtenerListaRegistroBiometricoResponse>))]
        public IActionResult ObtenerListaRegistroBiometrico([FromBody] string nombreRed)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.NombreRed = nombreRed;

            EstructuraBase<ObtenerListaRegistroBiometricoResponse> respuesta = this.ObtenerTodos<RegistroBiometricoTrx, ObtenerListaRegistroBiometricoResponse, ObtenerListaRegistroBiometricoIN>(
                new ObtenerListaRegistroBiometricoIN(),
                transaccion);


            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarRegistroBiometrico")]
        [Produces(typeof(EstructuraBase<AgregarRegistroBiometricoResponse>))]
        public IActionResult AgregarRegistroBiometrico([FromBody] RegistroBiometricoRequest peticionRegistroBiometrico)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.RegistroBiometricoRequest = peticionRegistroBiometrico;

            EstructuraBase<AgregarRegistroBiometricoResponse> respuesta = this.Insertar<RegistroBiometricoTrx, AgregarRegistroBiometricoResponse, AgregarRegistroBiometricoIN>(
                new AgregarRegistroBiometricoIN(),
                transaccion);


            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarRegistroBiometrico")]
        [Produces(typeof(EstructuraBase<ActualizarRegistroBiometricoResponse>))]
        public IActionResult ActualizarRegistroBiometrico([FromBody] RegistroBiometricoRequest registroBiometrico)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.RegistroBiometricoRequest = registroBiometrico;

            EstructuraBase<ActualizarRegistroBiometricoResponse> respuesta = this.Actualizar<RegistroBiometricoTrx, ActualizarRegistroBiometricoResponse, ActualizarRegistroBiometricoIN>(
                new ActualizarRegistroBiometricoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ObtenerTotalAtrasosMes")]
        [Produces(typeof(EstructuraBase<ObtenerTotalAtrasosMesResponse>))]
        public IActionResult ObtenerTotalAtrasosMes([FromBody] string nombreRed)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.NombreRed = nombreRed;

            EstructuraBase<ObtenerTotalAtrasosMesResponse> respuesta = this.Obtener<RegistroBiometricoTrx, ObtenerTotalAtrasosMesResponse, ObtenerTotalAtrasosMesIN>(
                new ObtenerTotalAtrasosMesIN(),
                transaccion);


            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ObtenerRegistroDiaUsuario")]
        [Produces(typeof(EstructuraBase<ObtenerRegistroDiaUsuarioResponse>))]
        public IActionResult ObtenerRegistroDiaUsuario([FromBody] string nombreRed)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.NombreRed = nombreRed;

            EstructuraBase<ObtenerRegistroDiaUsuarioResponse> respuesta = this.Obtener<RegistroBiometricoTrx, ObtenerRegistroDiaUsuarioResponse, ObtenerRegistroDiaUsuarioIN>(
                new ObtenerRegistroDiaUsuarioIN(),
                transaccion);


            return Ok(respuesta);
        }
    }
}
