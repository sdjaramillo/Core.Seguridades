﻿using Microsoft.AspNetCore.Mvc;
using Core.Common.Model.General;
using Core.Seguridades.BusinessLogic.Internal.Usuarios;
using Core.Common.Util.Helper;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Request.Usuarios;
using Core.Common.ProcessTemplate.Util;
using Core.Common.Model.Transaccion.Respuesta;

namespace Core.Seguridades.Controllers
{
    /// <summary>
    /// Controlador de usuario con peticiones HTTP
    /// </summary>
    [Route("api/[controller]")]
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
        [HttpPost]
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

        [HttpPut]
        [Route("ActualizarUsuario")]
        [Produces(typeof(EstructuraBase<ActualizarUsuarioResponse>))]
        public IActionResult ActualizarUsuario([FromBody] ActualizarUsuarioRequest usuario)
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            transaccion.UsuarioRequest = usuario;
            
            EstructuraBase<ActualizarUsuarioResponse> respuesta = this.Actualizar<UsuarioTrx, ActualizarUsuarioResponse, ActualizarUsuarioIN>(
                new ActualizarUsuarioIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarUsuario/{nombreRedUsuario}")]
        [Produces(typeof(EstructuraBase<EliminarUsuarioResponse>))]
        public IActionResult EliminarUsuario(string nombreRedUsuario)
        {
            UsuarioTrx transaccion = this.GenerarTransaccion<UsuarioTrx>();
            transaccion.UsuarioRequest.NombreRedUsuario = nombreRedUsuario;

            EstructuraBase<EliminarUsuarioResponse> respuesta = this.Eliminar<UsuarioTrx, EliminarUsuarioResponse, EliminarUsuarioIN>(
                new EliminarUsuarioIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
