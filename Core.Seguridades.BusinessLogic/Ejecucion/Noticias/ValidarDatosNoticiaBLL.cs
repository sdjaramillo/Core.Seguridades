using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Noticias
{
    public static class ValidarDatosNoticiaBLL
    {
        public static void ValidarCamposVacioNoticia(NoticiaTrx objetoTransaccional)
        {
            if(objetoTransaccional.NoticiaRequest.CodigoPermisoPublicacion==null ||
                objetoTransaccional.NoticiaRequest.Codigo == null||
                objetoTransaccional.NoticiaRequest.Titulo == null||
                objetoTransaccional.NoticiaRequest.Imagen == null ||
                objetoTransaccional.NoticiaRequest.Publico == null||
                objetoTransaccional.NoticiaRequest.CodigoPermisoPublicacion == "" ||
                objetoTransaccional.NoticiaRequest.Codigo == "" ||
                objetoTransaccional.NoticiaRequest.Titulo == "" ||
                objetoTransaccional.NoticiaRequest.Imagen == "" 
              )
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorNoticia.CamposVaciosNoticaRequest;
            }
        }
    }
}
