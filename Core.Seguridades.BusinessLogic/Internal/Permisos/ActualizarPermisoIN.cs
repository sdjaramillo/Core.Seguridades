using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Permisos;
using Core.Seguridades.Model.Transaccion.Response.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Internal.Permisos
{
    public class ActualizarPermisoIN : IActualizar<PermisoTrx, ActualizarPermisoResponse>
    {
        public void ActualizarInformacion(PermisoTrx objetoTransaccional)
        {
            ActualizarPermisoBLL.ActualizarPermiso(objetoTransaccional);
        }

        public void AgregarInformacion(PermisoTrx objetoTransaccional)
        {
            ObtenerTodoPermisoBLL.ObtenerTodoPermisos(objetoTransaccional);
        }

        public void HomologarInformacion(PermisoTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(PermisoTrx objetoTransaccional)
        {
            ValidarDatosPermisoBLL.ValidarCamposVaciosPermisosRequest(objetoTransaccional);
            ValidarExistenciaPermisoBLL.ExistenciaPermisoBaseDatos(objetoTransaccional);
        }
    }
}
