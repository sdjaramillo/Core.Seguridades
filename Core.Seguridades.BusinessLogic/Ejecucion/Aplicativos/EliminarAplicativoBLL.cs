using Core.Seguridades.DataAccess.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class EliminarAplicativoBLL
    {
        public static void EliminarAplicativo(AplicativosTrx objetoTransaccional)
        {
            EliminarAplicativoDAL.Execute(objetoTransaccional);
        }
    }
}
