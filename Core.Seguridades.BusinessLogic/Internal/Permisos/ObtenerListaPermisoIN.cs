using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Permisos;
using Core.Seguridades.Model.Transaccion.Response.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Internal.Permisos
{
    public class ObtenerListaPermisoIN : IObtenerTodos<PermisoTrx, ObtenerListaPermisoResponse>
    {
        public void AgregarInformacion(PermisoTrx objetoTransaccional)
        {
            ObtenerListaPermisoBLL.ObtenerListaPermisos(objetoTransaccional);
        }

        public void ValidarInformacion(PermisoTrx objetoTransaccional)
        {
            
        }
    }
}
