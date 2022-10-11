using Core.Common.Util.Helper.Datos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using System.DirectoryServices.AccountManagement;

namespace Core.Seguridades.Adapter.Autenticacion.ActiveDirectory
{
    /// <summary>
    /// Autenticación mediante active directory
    /// </summary>
    public static class AutenticarUsuarioActiveDirectoryADP 
    {
        /// <summary>
        /// Petición al servidor active directory y validación de las credenciales del usuario
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de autenticacion</param>
        /// <returns></returns>
        public static void AutenticacionActiveDirectory(AutenticacionTrx objetoTransaccional)
        {
            PrincipalContext pc = new PrincipalContext(ContextType.Domain, VariablesSistemaHelper.ObtenerValor(ConstantesVariablesSistema.IP_GENERAL_ACTIVE_DIRECTORY));
            bool respuesta = pc.ValidateCredentials(objetoTransaccional.UsuarioAutenticacionRequest.NombreRedUsuario, objetoTransaccional.UsuarioAutenticacionRequest.ContraseniaUsuario);
            objetoTransaccional.ResultadoAutenticacion = respuesta ;

        }
    }
}