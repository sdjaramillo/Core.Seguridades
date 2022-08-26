using Core.Seguridades.DataAccess.Usuarios;
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

        /// <summary>
        /// Método para limpiar los datos del active directory para obtener la empresa
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        private static void LimpiarNombreEmpresaActiveDirectory(UsuarioTrx objetoTransaccional)
        {
            foreach (var usuarioActiveDirectory in objetoTransaccional.ListaUsuariosActiveDirectory)
            {
                string activeDirectoryEmpresa = usuarioActiveDirectory.CadenaNombreEmpresa;
                string empresaNombre = "=,";
                if (activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa).Length > 1)
                {
                    empresaNombre = activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa)[1];
                }
                if (activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa).Length > 2)
                {
                    empresaNombre = activeDirectoryEmpresa.Split(MigrarUsuariosActiveDirectoryConstantes.IdentificarEmpresa)[2];
                }
                empresaNombre = empresaNombre.Split(",")[0];
                empresaNombre = empresaNombre.Split("=")[1];
                usuarioActiveDirectory.NombreEmpresa = empresaNombre;
            }
            
        }
    }
}
