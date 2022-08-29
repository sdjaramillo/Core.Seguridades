using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.Transaccion.Request.Usuarios;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Usuarios
{
    /// <summary>
    /// Objeto transaccional de usuarios
    /// </summary>
    public class UsuarioTrx : TransaccionBase
    {
        public UsuarioTrx() {
            ListaUsuarios = new List<Usuario>();
            ListaUsuariosActiveDirectory = new List<UsuarioActiveDirectory>();
            ListaUsuariosNuevos = new List<UsuarioActiveDirectory>();
            Usuario = new Usuario();
            UsuarioRequest = new ActualizarUsuarioRequest();
        }

        /// <summary>
        /// Usuario de la BD
        /// </summary>
        public Usuario Usuario { get; set; }

        /// <summary>
        /// Lista de usaurios de la BD
        /// </summary>
        public List<Usuario> ListaUsuarios { get; set; }

        /// <summary>
        /// Lista de usuarios nuevos entre active directory y la BD
        /// </summary>
        public List<UsuarioActiveDirectory> ListaUsuariosNuevos { get; set; }

        /// <summary>
        /// Lista de usuarios de Active Directory
        /// </summary>
        public List<UsuarioActiveDirectory> ListaUsuariosActiveDirectory { get; set; }

        /// <summary>
        /// Total numérico de usuarios nuevos
        /// </summary>
        public int CantidadUsuariosNuevos { get; set; }

        /// <summary>
        /// Total numéricos de usuarios eliminados
        /// </summary>
        public int CantidadUsuariosEliminados { get; set; }

        public ActualizarUsuarioRequest UsuarioRequest { get; set; }

    }
}
