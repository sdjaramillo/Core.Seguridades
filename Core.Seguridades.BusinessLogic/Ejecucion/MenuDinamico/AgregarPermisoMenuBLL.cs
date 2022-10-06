using Core.Seguridades.DataAccess.MenuDinamico;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico
{
    public static class AgregarPermisoMenuBLL
    {
        public static void AgregarPermisoMenuRol(MenusTrx objetoTransaccional)
        {
            AgregarPermisoMenuDAL.Execute(objetoTransaccional);
        }
    }
}
