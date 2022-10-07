using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Permisos;
using Core.Seguridades.Model.Transaccion.Response.Permisos;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Internal.Permisos
{
    public class AgregarPermisoIN : IInsertar<PermisoTrx, AgregarPermisoResponse>
    {
        public void AgregarInformacion(PermisoTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(PermisoTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(PermisoTrx objetoTransaccional)
        {
            AgregarPermisoBLL.AgregarPermiso(objetoTransaccional);
        }

        public void ValidarInformacion(PermisoTrx objetoTransaccional)
        {
            ValidarDatosPermisoBLL.ValidarCamposVaciosPermisosRequest(objetoTransaccional);
        }
    }
}
