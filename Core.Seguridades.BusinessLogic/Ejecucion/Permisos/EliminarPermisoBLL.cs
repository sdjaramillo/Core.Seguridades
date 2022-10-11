using Core.Seguridades.DataAccess.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class EliminarPermisoBLL
    {
        public static void EliminarPermiso(PermisoTrx objetoTransaccional)
        {
            EliminarPermisoDAL.Execute(objetoTransaccional);
        }
    }
}
