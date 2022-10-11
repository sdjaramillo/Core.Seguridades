using Core.Seguridades.DataAccess.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class ObtenerListaPermisoBLL
    {
        public static void ObtenerListaPermisos(PermisoTrx objetoTransaccional)
        {
            ObtenerListaPermisoDAL.Execute(objetoTransaccional);
        }
    }
}
