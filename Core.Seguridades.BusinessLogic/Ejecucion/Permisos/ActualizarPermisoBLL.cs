using Core.Seguridades.DataAccess.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class ActualizarPermisoBLL
    {
        public static void ActualizarPermiso(PermisoTrx objetoTransaccional)
        {
            ActualizarPermisoDAL.Execute(objetoTransaccional);
        }
    }
}
