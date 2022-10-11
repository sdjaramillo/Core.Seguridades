using Core.Seguridades.DataAccess.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class AgregarPermisoBLL
    {
        public static void AgregarPermiso(PermisoTrx objetoTransaccional)
        {
            AgregarPermisoDAL.Execute(objetoTransaccional);
        }
    }
}
