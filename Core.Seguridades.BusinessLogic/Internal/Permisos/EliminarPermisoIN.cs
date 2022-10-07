using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Permisos;
using Core.Seguridades.Model.Transaccion.Response.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Internal.Permisos
{
    public class EliminarPermisoIN : IEliminar<PermisoTrx, EliminarPermisoResponse>
    {
        public void AgregarInformacion(PermisoTrx objetoTransaccional)
        {
            ObtenerTodoPermisoBLL.ObtenerTodoPermisos(objetoTransaccional);
        }

        public void Eliminarnformacion(PermisoTrx objetoTransaccional)
        {
            EliminarPermisoBLL.EliminarPermiso(objetoTransaccional);
        }

        public void ValidarInformacion(PermisoTrx objetoTransaccional)
        {
            ValidarExistenciaPermisoBLL.ExistenciaPermisoBaseDatos(objetoTransaccional);
        }
    }
}
