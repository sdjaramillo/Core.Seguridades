﻿using Core.Seguridades.Model.Entidad.Usuarios;


namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    /// <summary>
    /// Respuesta de la lista de usuarios al obtener usuarios de la BD
    /// </summary>
    public class ObtenerListaUsuariosResponse
    {
        public ObtenerListaUsuariosResponse()
        {
            Usuarios = new List<Usuario>();
        }
        public List<Usuario> Usuarios { get; set; }
    }
}
