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
    public class ObtenerRegistroDiaUsuarioIN : IObtener<RegistroBiometricoTrx, ObtenerRegistroDiaUsuarioResponse>
    {
        public void AgregarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            ObtenerRegistroDiaUsuarioBLL.ObtenerRegistroDiaUsuario(objetoTransaccional);
        }

        public void ValidarInformacion(RegistroBiometricoTrx objetoTransaccional)
        {
            
        }
    }
}
