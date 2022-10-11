using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion;
using Core.Seguridades.BusinessLogic.Ejecucion.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Response.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;


namespace Core.Seguridades.BusinessLogic.Internal.CredencialesAccesos
{
    public class AgregarCredencialAccesoIN : IInsertar<CredencialAccesoTrx, AgregarCredencialAccesoResponse>
    {
        public void AgregarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
        }

        public void HomologarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
        }

        public void InsertarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            CredencialesAccesoInsertarBLL.InsertarCredencialesAcceso(objetoTransaccional);
        }

        public void ValidarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            //1. Encripta clave
            EncriptarClaveCredencialesAccesoBLL.EncriptarClave(objetoTransaccional);
            //2. Valida si existe ya usuario y password Creado
            CredencialesAccesosValidarInformacionBLL.ValidarExisteCredencial(objetoTransaccional);
        }
    }
}
