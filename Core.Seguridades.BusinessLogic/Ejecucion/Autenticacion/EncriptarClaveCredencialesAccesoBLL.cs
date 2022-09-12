using Core.Common.Util.Helper.API;
using Core.Common.Util.Helper.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    public static class EncriptarClaveCredencialesAccesoBLL
    {
        public static void EncriptarClave(AutenticacionTrx objetoTransaccional)
        {
            objetoTransaccional.CredencialAcceso.Clave = CryptographyHelper.EncryptString(objetoTransaccional.CredencialAcceso.Clave, SettingsHelper.ObtenerSettigsKey("Cryotography.Key"));
        }

        public static void EncriptarClave(CredencialAccesoTrx objetoTransaccional)
        {
            objetoTransaccional.CredencialAcceso.Clave = CryptographyHelper.EncryptString(objetoTransaccional.CredencialAcceso.Clave, SettingsHelper.ObtenerSettigsKey("Cryotography.Key"));
        }
    }
}
