using Core.Seguridades.DataAccess.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class ObtenerTodoPermisoBLL
    {
        public static void ObtenerTodoPermisos(PermisoTrx objetoTransaccional)
        {
            ObtenerTodoPermisosDAL.Execute(objetoTransaccional);
        }
    }
}
