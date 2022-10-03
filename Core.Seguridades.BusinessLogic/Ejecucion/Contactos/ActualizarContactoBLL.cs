using Core.Seguridades.DataAccess.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Contactos
{
    public static class ActualizarContactoBLL
    {
        public static void ActualizarContacto(ContactosTrx objetoTransaccional)
        {
            ActualizarContactoDAL.Execute(objetoTransaccional);
        }
    }
}
