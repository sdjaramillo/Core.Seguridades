using Core.Seguridades.Model.Entidad.Usuarios;
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
            using (var context = new PrincipalContext(ContextType.Domain, "10.0.0.211")) 
            { 
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context))) 
                { 
                    foreach (var result in searcher.FindAll()) 
                    { 
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        objetoTransaccional.ListaUsuariosActiveDirectory.Add(
                            new UsuarioActiveDirectory()
                            {
                                NombreUsuario = (string)de.Properties["givenName"].Value,
                                ApellidoUsuario = (string)de.Properties["sn"].Value,
                                CadenaNombreEmpresa = (string)de.Properties["distinguishedName"].Value,
                                FechaIngresoUsuario = (DateTime)de.Properties["whenCreated"].Value,
                                NombreRedUsuario = (string)de.Properties["sAMAccountName"].Value,
                                CorreoElectronicoUsuario = (string)de.Properties["userPrincipalName"].Value
                            });
                    }
                } 
            }
        }
    }
}
