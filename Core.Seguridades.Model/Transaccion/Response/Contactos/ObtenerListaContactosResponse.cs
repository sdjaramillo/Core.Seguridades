using Core.Seguridades.Model.Entidad.Contactos;

namespace Core.Seguridades.Model.Transaccion.Response.Contactos
{
    public class ObtenerListaContactosResponse
    {
        public ObtenerListaContactosResponse()
        {
            Contactos = new List<Contacto>();
        }
        public List<Contacto> Contactos { get; set; }
    }
}
