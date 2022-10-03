using Core.Seguridades.DataAccess.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Contactos
{
    public static class ObtenerListaContactosBLL
    {
        public static void ObtenerListaContactos(ContactosTrx objetoTransaccional)
        {
            ObtenerListaContactoDAL.Execute(objetoTransaccional);   
        }
    }
}
