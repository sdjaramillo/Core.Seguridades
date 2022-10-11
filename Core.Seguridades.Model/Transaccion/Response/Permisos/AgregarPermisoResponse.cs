using Core.Seguridades.Model.Transaccion.Request.Permisos;

namespace Core.Seguridades.Model.Transaccion.Response.Permisos
{
    public class AgregarPermisoResponse
    {
        public AgregarPermisoResponse()
        {
            NuevoPermiso = new PermisoRequest();
        }
        public PermisoRequest NuevoPermiso { get; set; }
    }
}
