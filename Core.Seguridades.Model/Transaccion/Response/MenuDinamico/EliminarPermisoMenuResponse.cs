using Core.Seguridades.Model.Entidad.MenuDinamico;

namespace Core.Seguridades.Model.Transaccion.Response.MenuDinamico
{
    public class EliminarPermisoMenuResponse
    {
        public EliminarPermisoMenuResponse()
        {
            EliminarPermisoMenu = new PermisoMenuRol();
        }
        public PermisoMenuRol EliminarPermisoMenu { get; set; }
    }
}
