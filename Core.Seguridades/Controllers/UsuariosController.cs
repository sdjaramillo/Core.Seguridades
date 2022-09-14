using Microsoft.AspNetCore.Mvc;
using Core.Seguridades.BusinessLogic.Internal.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Request.Usuarios;
using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;

namespace Core.Seguridades.Controllers
{
    /// <summary>
    /// Controlador de usuario con peticiones HTTP
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UsuariosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Petición HTTP tipo GET para obtener la lista de usuarios de la BD
        /// </summary>
        /// <returns>
        /// Lista de usuarios
        /// </returns>
        [HttpGet]
        [Route("ObtenerListaUsuarios")]
        [Produces(typeof(EstructuraBase<ObtenerListaUsuariosResponse>))]
        public IActionResult ObtenerListaUsuarios()
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<ObtenerListaUsuariosResponse> respuesta = this.ObtenerTodos<UsuarioTrx, ObtenerListaUsuariosResponse, ObtenerListaUsuariosIN>(
                new ObtenerListaUsuariosIN(),
                transaccion);


            return Ok(respuesta);
        }

        /// <summary>
        /// Peticion HTTP tipo PUT que permite la sincronización de usuarios de active directory con la BD
        /// </summary>
        /// <returns>
        /// Devuelve la cantidad de usuarios ingresados y eliminados
        /// </returns>
        [HttpPost]
        [Route("MigrarUsuariosActiveDirectory")]
        [Produces(typeof(EstructuraBase<MigrarUsuariosActiveDirectoryResponse>))]
        public IActionResult MigrarUsuariosActiveDirectory()
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<MigrarUsuariosActiveDirectoryResponse> respuesta = this.ProcesarTransaccionSimple<UsuarioTrx, MigrarUsuariosActiveDirectoryResponse, MigrarUsuariosActiveDirectoryIN>(
                new MigrarUsuariosActiveDirectoryIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarUsuario")]
        [Produces(typeof(EstructuraBase<ActualizarUsuarioResponse>))]
        public IActionResult ActualizarUsuario([FromBody] ActualizarUsuarioRequest usuario)
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            transaccion.ActualizarUsuarioRequest = usuario;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<ActualizarUsuarioResponse> respuesta = this.Actualizar<UsuarioTrx, ActualizarUsuarioResponse, ActualizarUsuarioIN>(
                new ActualizarUsuarioIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarUsuario/{nombreRed}")]
        [Produces(typeof(EstructuraBase<EliminarUsuarioResponse>))]
        public IActionResult EliminarUsuario(string nombreRed)
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            //transaccion.Usuario.NombreRed = nombreRed;
            transaccion.NombreRed = nombreRed;
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<EliminarUsuarioResponse> respuesta = this.Eliminar<UsuarioTrx, EliminarUsuarioResponse, EliminarUsuarioIN>(
                new EliminarUsuarioIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ObtenerUsuario")]
        [Produces(typeof(EstructuraBase<ObtenerUsuarioResponse>))]
        public IActionResult ObtenerUsuario([FromBody] ObtenerUsuarioRequest usuario)
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");
            transaccion.ObtenerUsuarioRequest = usuario;

            EstructuraBase<ObtenerUsuarioResponse> respuesta = this.Obtener<UsuarioTrx, ObtenerUsuarioResponse, ObtenerUsuarioIN>(
                new ObtenerUsuarioIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpGet]
        [Route("ObtenerListaCumpleanios")]
        [Produces(typeof(EstructuraBase<ObtenerListaCumpleaniosResponse>))]
        public IActionResult ObtenerListaCumpleanios()
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");

            EstructuraBase<ObtenerListaCumpleaniosResponse> respuesta = this.ObtenerTodos<UsuarioTrx, ObtenerListaCumpleaniosResponse, ObtenerListaCumpleaniosIN>(
                new ObtenerListaCumpleaniosIN(),
                transaccion);


            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ObtenerUsuarioAdministrador")]
        [Produces(typeof(EstructuraBase<ObtenerUsuarioAdministradorResponse>))]
        public IActionResult ObtenerUsuarioAdministrador([FromBody] ObtenerUsuarioAdministradorRequest usuario)
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            //transaccion.BaseDatos = _configuration.GetConnectionString("BD_SEGURIDADES");
            transaccion.RolAdministrador = usuario;

            EstructuraBase<ObtenerUsuarioAdministradorResponse> respuesta = this.Obtener<UsuarioTrx, ObtenerUsuarioAdministradorResponse, ObtenerUsuarioAdministradorIN>(
                new ObtenerUsuarioAdministradorIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
