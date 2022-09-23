using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Microsoft.AspNetCore.Mvc;
using Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiometricoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public BiometricoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("ObtenerListaRegistroBiometrico")]
        [Produces(typeof(EstructuraBase<ObtenerListaRegistroBiometricoResponse>))]
        public IActionResult ObtenerListaRegistroBiometrico([FromBody] ObtenerListaRegistroBiometricoRequest peticionRegistroBiometrico)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.RegistroBiometricoRequest = peticionRegistroBiometrico;

            EstructuraBase<ObtenerListaRegistroBiometricoResponse> respuesta = this.ObtenerTodos<RegistroBiometricoTrx, ObtenerListaRegistroBiometricoResponse, ObtenerListaRegistroBiometricoIN>(
                new ObtenerListaRegistroBiometricoIN(),
                transaccion);


            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarRegistroBiometrico")]
        [Produces(typeof(EstructuraBase<AgregarRegistroBiometricoResponse>))]
        public IActionResult AgregarRegistroBiometrico([FromBody] AgregarRegistroBiometricoRequest peticionRegistroBiometrico)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.RegistroBiometricoNuevoRequest = peticionRegistroBiometrico;

            EstructuraBase<AgregarRegistroBiometricoResponse> respuesta = this.Insertar<RegistroBiometricoTrx, AgregarRegistroBiometricoResponse, AgregarRegistroBiometricoIN>(
                new AgregarRegistroBiometricoIN(),
                transaccion);


            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarRegistroBiometrico")]
        [Produces(typeof(EstructuraBase<ActualizarRegistroBiometricoResponse>))]
        public IActionResult ActualizarRegistroBiometrico([FromBody] ActualizarRegistroBiometricoRequest registroBiometrico)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.ActualizarRegistroBiometrico = registroBiometrico;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<ActualizarRegistroBiometricoResponse> respuesta = this.Actualizar<RegistroBiometricoTrx, ActualizarRegistroBiometricoResponse, ActualizarRegistroBiometricoIN>(
                new ActualizarRegistroBiometricoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ObtenerTotalAtrasosMes")]
        [Produces(typeof(EstructuraBase<ObtenerTotalAtrasosMesResponse>))]
        public IActionResult ObtenerTotalAtrasosMes([FromBody] ObtenerTotalAtrasosMesRequest nombreRed)
        {
            RegistroBiometricoTrx transaccion = this.GenerarTransaccion<RegistroBiometricoTrx>();
            transaccion.AtrasosMesRequest = nombreRed;

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
