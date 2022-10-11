using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;

namespace Core.Seguridades.BusinessLogic.Internal.RegistrosBiometrico
{
    public class ObtenerListaRegistroBiometricoIN : IObtenerTodos<RegistroBiometricoTrx, ObtenerListaRegistroBiometricoResponse>
    {
        public void AgregarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ObtenerListaRegistroBiometricoBLL.ObtenerListaRegistroBiometrico(objetoTransaccional);
        }

        public void ValidarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
        }
    }
}
