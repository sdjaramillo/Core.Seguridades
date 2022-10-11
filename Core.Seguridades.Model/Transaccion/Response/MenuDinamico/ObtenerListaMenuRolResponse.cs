using Core.Seguridades.Model.Entidad.MenuDinamico;

namespace Core.Seguridades.Model.Transaccion.Response.MenuDinamico
{
    public class ObtenerListaMenuRolResponse
    {
        public ObtenerListaMenuRolResponse()
        {
            Menus = new List<Menu>();
        }
        public List<Menu> Menus { get; set; }
    }
}
