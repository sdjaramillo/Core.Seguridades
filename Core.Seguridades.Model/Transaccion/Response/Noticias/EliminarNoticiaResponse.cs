using Core.Seguridades.Model.Entidad.Noticias;

namespace Core.Seguridades.Model.Transaccion.Response.Noticias
{
    public class EliminarNoticiaResponse
    {
        public EliminarNoticiaResponse()
        {
            NoticiaEliminada = new Noticia();
        }
        public Noticia NoticiaEliminada { get; set; }
    }
}
