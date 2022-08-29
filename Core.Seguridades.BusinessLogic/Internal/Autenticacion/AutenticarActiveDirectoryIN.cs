using Core.Common.BusinessLogic.ProcessTemplate;
using Core.Common.Model.General;
using Core.Seguridades.Adapter.Autenticacion.ActiveDirectory;
using Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;

namespace Core.Seguridades.BusinessLogic.Internal.Autenticacion
{
    public class AutenticarActiveDirectoryIN : IProcesarTransaccion<AutenticacionTrx, AutenticarActiveDirectoryResponse>
    {
        public void AgregarInformacion(AutenticacionTrx objetoTransaccional)
        {
            //
        }

        public AutenticarActiveDirectoryResponse ArmaraPaginaRespuesta(AutenticacionTrx objetoTransaccional)
        {
            return null;
        }

        public AutenticarActiveDirectoryResponse ArmarObjetoRespuesta(AutenticacionTrx objetoTransaccional)
        {
            if (objetoTransaccional.Resultado.CodigoRespuesta == (int)Error.OperacionExitosa)
            {
                AutenticarActiveDirectoryResponse respuesta = new AutenticarActiveDirectoryResponse();
                return respuesta;
            }
            else
                return null;
        }

        public void AutorizarTransaccion(AutenticacionTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
        }

        public void EjecutarTransaccion(AutenticacionTrx objetoTransaccional)
        {
            AutenticarActiveDirectoryBBL.AutenticacionActiveDirectory(objetoTransaccional);
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
