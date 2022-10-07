using Core.Seguridades.Model.Transaccion.Request.Permisos;

namespace Core.Seguridades.Model.Transaccion.Response.Permisos
{
    public class ActualizarPermisoResponse
    {
        public ActualizarPermisoResponse() 
        {
            PermisoActualizado = new PermisoRequest();
        }
        public PermisoRequest PermisoActualizado { get; set; }
    }
}
