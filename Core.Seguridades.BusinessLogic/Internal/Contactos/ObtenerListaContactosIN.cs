using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Contactos;
using Core.Seguridades.Model.Transaccion.Response.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Internal.Contactos
{
    public class ObtenerListaContactosIN : IObtenerTodos<ContactosTrx, ObtenerListaContactosResponse>
    {
        public void AgregarInformacion(ContactosTrx objetoTransaccional)
        {
            ObtenerListaContactosBLL.ObtenerListaContactos(objetoTransaccional);
        }

        public void ValidarInformacion(ContactosTrx objetoTransaccional)
        {
        }
    }
}
