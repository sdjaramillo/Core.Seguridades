using Core.Seguridades.Model.Entidad.Noticias;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Noticias
{
    public static class ValidarExistenciaNoticiaBLL
    {
        public static void ExistenciaNoticiaBaseDatos(NoticiaTrx objetoTransaccional)
        {
            List<Noticia> listaNoticiasBaseDatos = objetoTransaccional.ListadoNoticias;
            if(listaNoticiasBaseDatos.Count > 0)
            {
                var noticiaVerificada = listaNoticiasBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.NoticiaRequest.Codigo.ToString());
                objetoTransaccional.NoticiaValida = noticiaVerificada;
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta=(int)ErrorNoticia.NoExisteNoticiaBaseDatos;
            }
        }
    }
}
