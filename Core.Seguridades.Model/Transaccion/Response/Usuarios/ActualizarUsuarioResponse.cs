using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.Transaccion.Request.Usuarios;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    /// <summary>
    /// Respuesta al actualizar un usuario
    /// </summary>
    public class ActualizarUsuarioResponse
    {
        public ActualizarUsuarioResponse ()
        {
            Usuario = new ActualizarUsuarioRequest();
        }
        public ActualizarUsuarioRequest Usuario { get; set; }
    }
}
