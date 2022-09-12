using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;


namespace Core.Seguridades.BusinessLogic.Internal.Autenticacion
{
    public class GenerarTokenIN : IProcesarTransaccionSimple<AutenticacionTrx, GenerarTokenResponse>
    {
        public void AgregarInformacion(AutenticacionTrx objetoTransaccional)
        {

        }

        public void EjecutarTransaccion(AutenticacionTrx objetoTransaccional)
        {
            GenerarTokenBLL.GenerarToken(objetoTransaccional);
        }

        public void ValidarInformacion(AutenticacionTrx objetoTransaccional)
        {
            //1.EncriptarClave
            EncriptarClaveCredencialesAccesoBLL.EncriptarClave(objetoTransaccional);
            //1.Validar existe
            AutenticarCredencialesAccesoBLL.AutenticarCredencialesAcceso(objetoTransaccional);
        }
    }
}
