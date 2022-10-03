using Core.Seguridades.DataAccess.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Contactos
{
    public static class EliminarContactoBLL
    {
        public static void EliminarContacto(ContactosTrx objetoTransaccional)
        {
            EliminarContactoDAL.Execute(objetoTransaccional);
        }
    }
}
