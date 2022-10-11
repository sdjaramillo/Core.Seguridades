using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Response.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;

namespace Core.Seguridades.BusinessLogic.Internal.MenuDinamico
{
    public class EliminarPermisoMenuIN : IEliminar<MenusTrx, EliminarPermisoMenuResponse>
    {
        public void AgregarInformacion(MenusTrx objetoTransaccional)
        {
            ObtenerListaPermisoMenuBLL.ObtenerListaPermisoMenuRol(objetoTransaccional);
        }

        public void Eliminarnformacion(MenusTrx objetoTransaccional)
        {
            EliminarPermisoMenuBLL.EliminarPermisoMenu(objetoTransaccional);
        }

        public void ValidarInformacion(MenusTrx objetoTransaccional)
        {
            ValidarExistenciaPermisoMenuBLL.ExistenciaPermisoMenuBaseDatos(objetoTransaccional);
        }
    }
}
