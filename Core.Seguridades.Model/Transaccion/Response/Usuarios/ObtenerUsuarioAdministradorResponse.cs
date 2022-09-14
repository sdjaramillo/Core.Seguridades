using Core.Seguridades.Model.Entidad.Usuarios;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    public class ObtenerUsuarioAdministradorResponse
    {
        public ObtenerUsuarioAdministradorResponse()
        {
            TipoAdministrador = new Administrador();
        }
        public Administrador TipoAdministrador { get; set; }
    }
}
