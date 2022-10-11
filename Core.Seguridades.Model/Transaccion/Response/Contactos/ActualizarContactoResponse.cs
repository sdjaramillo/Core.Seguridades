using Core.Seguridades.Model.Transaccion.Request.Contactos;

namespace Core.Seguridades.Model.Transaccion.Response.Contactos
{
    public class ActualizarContactoResponse
    {
        public ActualizarContactoResponse()
        {
            ContactoActualizado = new ContactoRequest();
        }
        public ContactoRequest ContactoActualizado { get; set; }
    }
}
