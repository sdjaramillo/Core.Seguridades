using Core.Seguridades.DataAccess.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ActualizarAplicativoBLL
    {
        public static void ActualizarAplicativo(AplicativosTrx objetoTransaccional)
        {
            ActualizarAplicativoDAL.Execute(objetoTransaccional);
        }
    }
}
