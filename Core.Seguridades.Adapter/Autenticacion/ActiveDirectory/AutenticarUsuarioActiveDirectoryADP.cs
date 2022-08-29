using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using System.DirectoryServices.AccountManagement;

namespace Core.Seguridades.Adapter.Autenticacion.ActiveDirectory
{
    public static class AutenticarUsuarioActiveDirectoryADP 
    {
        public static bool AutenticacionActiveDirectory(AutenticacionTrx objetoTransaccional)
        {
            PrincipalContext pc = new PrincipalContext(ContextType.Domain, "10.0.0.211");
            bool respuesta = pc.ValidateCredentials(objetoTransaccional.UsuarioAutenticacionRequest.NombreRedUsuario, objetoTransaccional.UsuarioAutenticacionRequest.ContraseniaUsuario);
            objetoTransaccional.ResultadoAutenticacion = respuesta;

            return respuesta;
        }
    }
}