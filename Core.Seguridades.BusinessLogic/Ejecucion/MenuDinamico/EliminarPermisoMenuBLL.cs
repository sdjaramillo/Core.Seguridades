using Core.Seguridades.DataAccess.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;

namespace Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico
{
    public static class EliminarPermisoMenuBLL
    {
        public static void EliminarPermisoMenu(MenusTrx objetoTransaccional)
        {
            EliminarPermisoMenuDAL.Execute(objetoTransaccional);
        }
    }
}
