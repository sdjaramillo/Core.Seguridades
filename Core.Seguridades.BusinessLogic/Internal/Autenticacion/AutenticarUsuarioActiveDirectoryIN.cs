using Core.Common.Model.ExcepcionServicio;
using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion;
using Core.Seguridades.Model.Transaccion.Response.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;

namespace Core.Seguridades.BusinessLogic.Internal.Autenticacion
{
    /// <summary>
    /// Logica interna para el proceso de actenticar un usuarios de active directory 
    /// </summary>
    public class AutenticarUsuarioActiveDirectoryIN : IProcesarTransaccionSimple<AutenticacionTrx, AutenticarActiveDirectoryResponse>
    {
        public void AgregarInformacion(AutenticacionTrx objetoTransaccional)
        {
            AutenticarActiveDirectoryBLL.AutenticarUsuariosActiveDirectory(objetoTransaccional);
        }

        public void EjecutarTransaccion(AutenticacionTrx objetoTransaccional)
        {
        }

        public void ValidarInformacion(AutenticacionTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
            ValidarDatosActiveDirectoryBLL.ValidarCamposVaciosAutenticacion(objetoTransaccional);
            ValidarDatosActiveDirectoryBLL.ValidarCredencialesCorrectas(objetoTransaccional);

        }
    }
}
