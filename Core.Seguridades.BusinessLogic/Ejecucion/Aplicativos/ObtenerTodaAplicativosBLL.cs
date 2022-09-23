using Core.Seguridades.DataAccess.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ObtenerTodaAplicativosBLL
    {
        public static void ObtenerListaAplicativos(AplicativosTrx objetoTransaccional)
        {
            ObtenerTodaAplicativosDAL.Execute(objetoTransaccional);
        }
    }
}
