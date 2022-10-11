using Core.Seguridades.DataAccess.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;

namespace Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico
{
    public static class ActualizarRegistroBiometricBLL
    {
        public static void ActualizarRegsitroBiometrico(RegistroBiometricoTrx objetoTransaccional)
        {
            ActualizarRegistroBiometricDAL.Execute(objetoTransaccional);
        }
    }
}
