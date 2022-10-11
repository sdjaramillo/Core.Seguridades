using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Contactos;
using Core.Seguridades.Model.Transaccion.Response.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Internal.Contactos
{
    public class EliminarContactoIN : IEliminar<ContactosTrx, EliminarContactoResponse>
    {
        public void AgregarInformacion(ContactosTrx objetoTransaccional)
        {
            ObtenerListaContactosBLL.ObtenerListaContactos(objetoTransaccional);
        }

        public void Eliminarnformacion(ContactosTrx objetoTransaccional)
        {
            EliminarContactoBLL.EliminarContacto(objetoTransaccional);
        }

        public void ValidarInformacion(ContactosTrx objetoTransaccional)
        {
            ValidarExistenciaContactoBLL.ExistenciaContactoBaseDatos(objetoTransaccional);
        }
    }
}
