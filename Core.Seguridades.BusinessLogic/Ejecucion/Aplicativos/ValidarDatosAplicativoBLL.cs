using Core.Common.Model.ExcepcionServicio;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ValidarDatosAplicativoBLL
    {
        public static void ValidarCamposVaciosAplicativoRequest(AplicativosTrx objetoTransaccional)
        {
            if(objetoTransaccional.NuevaAplicativoRequest.Codigo==null||
                objetoTransaccional.NuevaAplicativoRequest.Nombre==null||
                objetoTransaccional.NuevaAplicativoRequest.Logo==null||
                objetoTransaccional.NuevaAplicativoRequest.Ruta==null||
                objetoTransaccional.NuevaAplicativoRequest.Codigo == "" ||
                objetoTransaccional.NuevaAplicativoRequest.Nombre == "" ||
                objetoTransaccional.NuevaAplicativoRequest.Logo == "" ||
                objetoTransaccional.NuevaAplicativoRequest.Ruta == ""
               )
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.CamposVaciosAplicativoRequest;
                //throw new ExcepcionServicio((int)ErrorAplicativo.CamposVaciosAplicativoRequest);
            }
        }
    }
}
