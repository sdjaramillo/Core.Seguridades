using Core.Seguridades.Model.Transaccion.Request.Noticias;

namespace Core.Seguridades.Model.Transaccion.Response.Noticias
{
    public class AgregarNoticiaResponse
    {
        public AgregarNoticiaResponse()
        {
            NuevaNotica=new NoticiaRequest();
        }
        public NoticiaRequest NuevaNotica { get; set; }
    }
}
