using Core.Seguridades.DataAccess.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Noticias
{
    public static class EliminarNoticaBLL
    {
        public static void EliminarNoticia(NoticiaTrx objetoTransaccional)
        {
            EliminarNoticiaDAL.Execute(objetoTransaccional);
        }
    }
}
