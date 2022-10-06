using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Response.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.MenuDinamico
{
    public class AgregarPermisoMenuIN : IInsertar<MenusTrx, AgregarPermisoMenuResponse>
    {
        public void AgregarInformacion(MenusTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(MenusTrx objetoTransaccional)
        {
        }

        public void InsertarInformacion(MenusTrx objetoTransaccional)
        {
            AgregarPermisoMenuBLL.AgregarPermisoMenuRol(objetoTransaccional);
        }

        public void ValidarInformacion(MenusTrx objetoTransaccional)
        {
        }
    }
}
