using Core.Seguridades.DataAccess.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
