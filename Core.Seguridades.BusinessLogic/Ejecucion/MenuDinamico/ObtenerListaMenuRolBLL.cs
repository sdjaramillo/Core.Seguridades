using Core.Seguridades.DataAccess.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;

namespace Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico
{
    public static class ObtenerListaMenuRolBLL
    {
        public static void ObtenerListaMenuRol(MenusTrx objetoTransaccional)
        {
            ObtenerListaMenuRolDAL.Execute(objetoTransaccional);
        }
    }
}
