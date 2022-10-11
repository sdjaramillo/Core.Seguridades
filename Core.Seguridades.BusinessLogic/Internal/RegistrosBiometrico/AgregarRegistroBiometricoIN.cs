using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;


namespace Core.Seguridades.BusinessLogic.Internal.RegistrosBiometrico
{
    public class AgregarRegistroBiometricoIN : IInsertar<RegistroBiometricoTrx, AgregarRegistroBiometricoResponse>
    {
        public void AgregarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ObtenerHorarioLaboralBLL.ObtenerHorarioLaboral(objetoTransaccional);
        }

        public void HomologarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ObtenerTotalAtrasosMesBLL.ObtenerTotalAtrasosMes(objetoTransaccional);
            AgregarRegistroBiometricoBLL.AgregarRegistroBiometrico(objetoTransaccional);
        }

        public void ValidarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ValidarDatosRegistroBiometricoBLL.ValidarParametrosVaciosRegistroNuevo(objetoTransaccional);
        }
    }
}
