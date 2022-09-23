using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos;
using Core.Seguridades.Model.Transaccion.Response.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.Aplicativos
{
    public class ActualizarAplicativoIN : IActualizar<AplicativosTrx, ActualizarAplicativoResponse>
    {
        public void ActualizarInformacion(AplicativosTrx objetoTransaccional)
        {
            ActualizarAplicativoBLL.ActualizarAplicativo(objetoTransaccional);
        }

        public void AgregarInformacion(AplicativosTrx objetoTransaccional)
        {
            ObtenerTodaAplicativosBLL.ObtenerListaAplicativos(objetoTransaccional);
        }

        public void HomologarInformacion(AplicativosTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(AplicativosTrx objetoTransaccional)
        {
            ValidarDatosAplicativoBLL.ValidarCamposVaciosAplicativoRequest(objetoTransaccional);
            objetoTransaccional.AplicativoCodigo = objetoTransaccional.NuevaAplicativoRequest.Codigo;
            ValidarExistenciaAplicacionBLL.ExistenciaAplicativoBaseDatos(objetoTransaccional);
        }
    }
}
