using Core.Seguridades.Model.Entidad.Contactos;

namespace Core.Seguridades.Model.Transaccion.Response.Contactos
{
    public class EliminarContactoResponse
    {
        public EliminarContactoResponse()
        {
            EliminarContacto = new Contacto();
        }
        public Contacto EliminarContacto { get; set; }
    }
}
