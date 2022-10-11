using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;

namespace Core.Seguridades.BusinessLogic.Internal.RegistrosBiometrico
{
    public class ActualizarRegistroBiometricoIN : IActualizar<RegistroBiometricoTrx, ActualizarRegistroBiometricoResponse>
    {
        public void ActualizarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ActualizarRegistroBiometricBLL.ActualizarRegsitroBiometrico(objetoTransaccional);
        }

        public void AgregarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
        }

        public void HomologarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ValidarDatosRegistroBiometricoBLL.ValidarParametrosVaciosRegistroActualizar(objetoTransaccional);
        }
    }
}
