using Core.Seguridades.Model.Entidad.Noticias;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Noticias
{
    public static class ValidarExistenciaNoticiaBLL
    {
        public static void ExistenciaNoticiaBaseDatos(NoticiaTrx objetoTransaccional)
        {
            List<Noticia> ListaNoticiasBaseDatos = objetoTransaccional.ListadoNoticias;
            if(ListaNoticiasBaseDatos.Count > 0)
            {
                try
                {
                    var noticiaVerificada = ListaNoticiasBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.CodigoNoticia.ToString());
                    objetoTransaccional.NoticiaValida = noticiaVerificada;
                }catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorNoticia.NoExisteNoticiaBaseDatos;
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta=(int)ErrorNoticia.NoExisteNoticiaBaseDatos;
            }
        }
    }
}
