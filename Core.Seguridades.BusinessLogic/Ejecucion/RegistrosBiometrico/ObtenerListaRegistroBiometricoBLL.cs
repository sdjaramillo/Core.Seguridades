using Core.Seguridades.DataAccess.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;

namespace Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico
{
    public static class ObtenerListaRegistroBiometricoBLL
    {
        public static void ObtenerListaRegistroBiometrico(RegistroBiometricoTrx objetoTransaccional)
        {
            ObtenerListaRegistroBiometricoDAL.Execute(objetoTransaccional);
        }
    }
}
