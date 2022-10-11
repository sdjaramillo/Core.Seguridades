using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Preguntas
{
    public static class ValidarDatosPreguntaBLL
    {
        public static void ValidarCamposVaciosPregunta(PreguntaTrx objetoTransaccional)
        {
            if(objetoTransaccional.PreguntaRequest.Codigo==null||
                objetoTransaccional.PreguntaRequest.CodigoPermisoPublicacion==null||
                objetoTransaccional.PreguntaRequest.Titulo==null||
                objetoTransaccional.PreguntaRequest.Imagen==null||
                objetoTransaccional.PreguntaRequest.Publico==null||
                objetoTransaccional.PreguntaRequest.Codigo == "" ||
                objetoTransaccional.PreguntaRequest.CodigoPermisoPublicacion == "" ||
                objetoTransaccional.PreguntaRequest.Titulo == "" ||
                objetoTransaccional.PreguntaRequest.Imagen == "")
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta=(int)ErrorPregunta.CamposVaciosPreguntaRequest;
            }
        }
    }
}
