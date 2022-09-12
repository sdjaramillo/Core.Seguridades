using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Common.Util.Helper.API;
using Core.Common.Util.Helper.Autenticacion;
using Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion;
using Core.Seguridades.BusinessLogic.Ejecucion.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Response.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.CredencialesAccesos
{
    public class ActualizarCredencialAccesoIN : IActualizar<CredencialAccesoTrx, ActualizarCredencialAccesoResponse>
    {
        public void ActualizarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            CredencialesAccesosActualizarBLL.ActualizarCredencialAcceso(objetoTransaccional);
        }

        public void AgregarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(CredencialAccesoTrx objetoTransaccional)
        {
            EncriptarClaveCredencialesAccesoBLL.EncriptarClave(objetoTransaccional);
        }
    }
}
