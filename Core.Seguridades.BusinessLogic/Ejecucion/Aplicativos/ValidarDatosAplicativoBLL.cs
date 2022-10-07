using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ValidarDatosAplicativoBLL
    {
        public static void ValidarCamposVaciosAplicativoRequest(AplicativosTrx objetoTransaccional)
        {
            if(objetoTransaccional.AplicativoRequest.Codigo==null||
                objetoTransaccional.AplicativoRequest.Nombre==null||
                objetoTransaccional.AplicativoRequest.Logo==null||
                objetoTransaccional.AplicativoRequest.Ruta==null||
                objetoTransaccional.AplicativoRequest.Codigo == "" ||
                objetoTransaccional.AplicativoRequest.Nombre == "" ||
                objetoTransaccional.AplicativoRequest.Logo == "" ||
                objetoTransaccional.AplicativoRequest.Ruta == ""
               )
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.CamposVaciosAplicativoRequest;
                //throw new ExcepcionServicio((int)ErrorAplicativo.CamposVaciosAplicativoRequest);
            }
        }
    }
}
