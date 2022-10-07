using Core.Seguridades.Model.Entidad.Permisos;

namespace Core.Seguridades.Model.Transaccion.Response.Permisos
{
    public class ObtenerListaPermisoResponse
    {
        public ObtenerListaPermisoResponse()
        {
            Permisos = new List<Permiso>();
        }
        public List<Permiso> Permisos { get; set; }
    }
}
