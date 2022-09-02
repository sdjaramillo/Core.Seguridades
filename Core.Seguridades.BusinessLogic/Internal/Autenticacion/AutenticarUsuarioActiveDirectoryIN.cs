using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;

namespace Core.Seguridades.BusinessLogic.Internal.Autenticacion
{
    /// <summary>
    /// Logica interna para el proceso de actenticar un usuarios de active directory 
    /// </summary>
    public class AutenticarUsuarioActiveDirectoryIN : IProcesarTransaccion<AutenticacionTrx, AutenticarActiveDirectoryResponse>
    {
        public void AgregarInformacion(AutenticacionTrx objetoTransaccional)
        {
            //
        }

        public void AutorizarTransaccion(AutenticacionTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
        }

        public void EjecutarTransaccion(AutenticacionTrx objetoTransaccional)
        {
            AutenticarActiveDirectoryBBL.AutenticarUsuariosActiveDirectory(objetoTransaccional);
        }

        public void ReversarTransaccion(AutenticacionTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
        }

        public void ValidarInformacion(AutenticacionTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
            ValidarDatosActiveDirectoryBLL.ValidarCamposVaciosAutenticacion(objetoTransaccional);
        }
    }
}
