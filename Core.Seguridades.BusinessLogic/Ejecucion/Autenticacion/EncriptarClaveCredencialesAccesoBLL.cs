using Core.Common.Util.Helper.API;
using Core.Common.Util.Helper.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    public static class EncriptarClaveCredencialesAccesoBLL
    {
        /// <summary>
        /// Metodo para encriptar claves de credenciales de acceso
        /// </summary>
        /// <param name="objetoTransaccional"></param>
        public static void EncriptarClave(AutenticacionTrx objetoTransaccional)
        {
            objetoTransaccional.CredencialAcceso.Clave = CryptographyHelper.EncryptString(objetoTransaccional.CredencialAcceso.Clave, SettingsHelper.ObtenerSettigsKey("Cryotography.Key"));
        }

        /// <summary>
        /// Metodo para encriptar credenciales de acceso
        /// </summary>
        /// <param name="objetoTransaccional"></param>
        public static void EncriptarClave(CredencialAccesoTrx objetoTransaccional)
        {
            objetoTransaccional.CredencialAcceso.Clave = CryptographyHelper.EncryptString(objetoTransaccional.CredencialAcceso.Clave, SettingsHelper.ObtenerSettigsKey("Cryotography.Key"));
        }
    }
}
