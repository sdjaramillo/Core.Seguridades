using Core.Seguridades.DataAccess.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ObtenerListaAplicativosBLL
    {
        public static void ObtenerListaAplicativo(AplicativosTrx objetoTransaccional)
        {
            ObtenerListaAplicativoDAL.Execute(objetoTransaccional);
        }
    }
}
