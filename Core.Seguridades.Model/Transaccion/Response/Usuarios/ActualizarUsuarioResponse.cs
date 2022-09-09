using Core.Seguridades.Model.Entidad.Usuarios;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    /// <summary>
    /// Respuesta al actualizar un usuario
    /// </summary>
    public class ActualizarUsuarioResponse
    {
        public ActualizarUsuarioResponse ()
        {
            Usuario = new Usuario ();
        }
        public Usuario Usuario { get; set; }
    }
}
