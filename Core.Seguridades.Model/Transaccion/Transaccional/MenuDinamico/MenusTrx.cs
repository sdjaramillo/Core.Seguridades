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
            NombreRed = "";
            MenuRequest = new ObtenerListaMenuRolRequest();
            ValorLogo = "";
            PermisoMenuRequest = new PermisoMenuRequest();
            EliminarPermisoMenuRequest = new EliminarPermisoMenuRequest();
            ListaPermisoMenu = new List<PermisoMenuRol>();
            PermisoMenuValido = new PermisoMenuRol();
        }
        public List<Menu> ListaMenu { get; set; }
        public ObtenerListaMenuRolRequest MenuRequest { get; set; }
        public string NombreRed { get; set; }
        public string ValorLogo { get; set; }
        public PermisoMenuRequest PermisoMenuRequest { get; set; }
        public EliminarPermisoMenuRequest EliminarPermisoMenuRequest { get; set; }
        public List<PermisoMenuRol> ListaPermisoMenu { get; set; }
        public PermisoMenuRol PermisoMenuValido { get; set; }
    }
}
