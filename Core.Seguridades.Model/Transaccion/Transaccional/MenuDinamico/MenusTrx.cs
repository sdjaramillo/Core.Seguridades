using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Request.MenuDinamico;

namespace Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico
{
    public class MenusTrx : TransaccionBase
    {
        public MenusTrx() 
        {
            ListaMenu = new List<Menu>();
        }
        public List<Menu> ListaMenu { get; set; }
        public ObtenerListaMenuRolRequest MenuRequest { get; set; }
    }
}
