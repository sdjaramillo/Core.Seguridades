using Microsoft.AspNetCore.Mvc;
using Core.Common.Model.General;
using Core.Seguridades.Model.Transaccion;
using Core.Seguridades.BusinessLogic.Internal.Usuarios;
using Core.Common.Util.Helper;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.DataAccess.Usuarios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core.Seguridades.Controllers
{
    /// <summary>
    /// Controlador de usuario con peticiones HTTP
    /// </summary>
    [Route("api/Core.Seguridades/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
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
        [HttpPut]
        [Route("MigrarUsuariosActiveDirectory")]
        [Produces(typeof(EstructuraBase<MigrarUsuariosActiveDirectoryResponse>))]
        public IActionResult MigrarUsuariosActiveDirectory()
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();

            EstructuraBase<MigrarUsuariosActiveDirectoryResponse> respuesta = this.Insertar<UsuarioTrx, MigrarUsuariosActiveDirectoryResponse, MigrarUsuariosActiveDirectoryIN>(
                new MigrarUsuariosActiveDirectoryIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
