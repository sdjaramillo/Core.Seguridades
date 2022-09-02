using Core.Seguridades.Adapter.Autenticacion.ActiveDirectory;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    /// <summary>
    /// Autenticar usuarios de active directory para inicio de sesión
    /// </summary>
    public static class AutenticarActiveDirectoryBBL
    {
        /// <summary>
        /// Autentucación active directory usando capa adapter
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de autenticacion</param>
        public static void AutenticarUsuariosActiveDirectory(AutenticacionTrx objetoTransaccional)
        {
            AutenticarUsuarioActiveDirectoryADP.AutenticacionActiveDirectory(objetoTransaccional);
        }
    }
}
