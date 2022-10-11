using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.RegistrosBiometrico
{
    public class ObtenerTotalAtrasosMesIN : IObtener<RegistroBiometricoTrx, ObtenerTotalAtrasosMesResponse>
    {
        public void AgregarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ObtenerTotalAtrasosMesBLL.ObtenerTotalAtrasosMes(objetoTransaccional);
        }

        public void ValidarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            
        }
    }
}
