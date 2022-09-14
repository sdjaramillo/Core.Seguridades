using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Lógica de ejecución para obtener usuarios de BD y Active Directory
    /// </summary>
    public static class ObtenerUsuariosBLL
    {
        /// <summary>
        /// Método que obtiene la lista de usuarios almacenados en la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void ObtenerListaUsuarios(UsuarioTrx objetoTransaccional)
        {
            ObtenerListaUsuariosDAL.Execute(objetoTransaccional);            
        }

        /// <summary>
        /// Método que obtiene los 6 datos del active directory por cada usuario
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void ObtenerListaUsuariosActiveDirectory(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosActiveDirectoryDAL.Execute(objetoTransaccional);
            LimpiarNombreEmpresaActiveDirectory(objetoTransaccional);
        }

        public static void ObtenerUsuario(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuarioDAL.Execute(objetoTransaccional);
        }
        /// <summary>
        /// Método para limpiar los datos del active directory para obtener la empresa
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        private static void LimpiarNombreEmpresaActiveDirectory(UsuarioTrx objetoTransaccional)
        {
            foreach (var usuarioActiveDirectory in objetoTransaccional.ListaUsuariosActiveDirectory)
            {
                string activeDirectoryEmpresa = usuarioActiveDirectory.CadenaNombreEmpresa;
                
                string empresaNombre = null;
                string ciudadCodigo = "UIO";
                if (activeDirectoryEmpresa != null)
                {
                    if (activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa).Length > 1)
                    {
                        empresaNombre = activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa)[0];
                        empresaNombre = empresaNombre.Replace(" ", String.Empty);
                        ciudadCodigo = activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa)[1];
                        ciudadCodigo = ciudadCodigo.Replace(" ", String.Empty);
                    }
                    else
                    {
                        empresaNombre = activeDirectoryEmpresa;
                    }
                    usuarioActiveDirectory.NombreEmpresa = empresaNombre;
                    usuarioActiveDirectory.CiudadUsuario = ciudadCodigo;
                }
            }
            
        }
    }
}
