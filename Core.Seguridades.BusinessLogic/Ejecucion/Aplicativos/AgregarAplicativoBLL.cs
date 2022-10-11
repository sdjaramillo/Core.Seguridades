using Core.Seguridades.DataAccess.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class AgregarAplicativoBLL
    {
        public static void AgregarAplicativo(AplicativosTrx objetoTransaccional)
        {
            AgregarAplicativoDAL.Execute(objetoTransaccional);
        }
    }
}
