using Core.Seguridades.DataAccess.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Contactos
{
    public static class AgregarContactoBLL
    {
        public static void AgregarContacto(ContactosTrx objetoTransaccional)
        {
            AgregarContactoDAL.Execute(objetoTransaccional);
        }
    }
}
