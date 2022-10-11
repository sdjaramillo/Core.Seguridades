using Core.Common.DataAccess.Procesos.VariablesSistema;
using Core.Common.Util.Helper.Datos;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System.DirectoryServices.AccountManagement;
using DirectoryEntry = System.DirectoryServices.DirectoryEntry;

namespace Core.Seguridades.DataAccess.Usuarios
{
    /// <summary>
    /// Lógica de acceso a la lista de usuarios de Active Directory 
    /// </summary>
    public static class ObtenerUsuariosActiveDirectoryDAL
    {
        /// <summary>
        /// Método de ejecución para obtener los usuarios de active directory
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            using (var context = new PrincipalContext(ContextType.Domain, VariablesSistemaHelper.ObtenerValor(ConstantesVariablesSistema.IP_GENERAL_ACTIVE_DIRECTORY)))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        objetoTransaccional.ListaUsuariosActiveDirectory.Add(
                            new UsuarioActiveDirectory()
                            {
                                NombreUsuario = (string)de.Properties[MigrarUsuariosActiveDirectoryConstantes.NombreUsuario].Value,
                                ApellidoUsuario = (string)de.Properties[MigrarUsuariosActiveDirectoryConstantes.ApellidoUsuario].Value,
                                CadenaNombreEmpresa = (string)de.Properties[MigrarUsuariosActiveDirectoryConstantes.CadenaNombreEmpresa].Value,
                                FechaIngresoUsuario = (DateTime)de.Properties[MigrarUsuariosActiveDirectoryConstantes.FechaIngresoUsuario].Value,
                                NombreRedUsuario = (string)de.Properties[MigrarUsuariosActiveDirectoryConstantes.NombreRedUsuario].Value,
                                CorreoElectronicoUsuario = (string)de.Properties[MigrarUsuariosActiveDirectoryConstantes.CorreoElectronicoUsuario].Value
                            });
                    }
                }
            }
        }
    }
}
