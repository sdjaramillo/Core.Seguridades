using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Response.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;

namespace Core.Seguridades.BusinessLogic.Internal.MenuDinamico
{
    public class ObtenerListaMenuRolIN : IObtenerTodos<MenusTrx, ObtenerListaMenuRolResponse>
    {
        public void AgregarInformacion(MenusTrx objetoTransaccional)
        {
            ObtenerListaMenuRolBLL.ObtenerListaMenuRol(objetoTransaccional);
        }

        public void ValidarInformacion(MenusTrx objetoTransaccional)
        {
            
        }
    }
}
