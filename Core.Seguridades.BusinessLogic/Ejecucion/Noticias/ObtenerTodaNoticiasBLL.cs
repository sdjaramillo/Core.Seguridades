using Core.Seguridades.DataAccess.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Noticias
{
    public static class ObtenerTodaNoticiasBLL
    {
        public static void ObtenerListaNoticias(NoticiaTrx objetoTransaccional)
        {
            ObtenerTodaNoticiasDAL.Execute(objetoTransaccional);
        }
    }
}
