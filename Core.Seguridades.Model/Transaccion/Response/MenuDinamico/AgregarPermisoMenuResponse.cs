using Core.Seguridades.Model.Transaccion.Request.MenuDinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.MenuDinamico
{
    public class AgregarPermisoMenuResponse
    {
        public AgregarPermisoMenuResponse() 
        {
            NuevoPermisoMenu = new PermisoMenuRequest();
        }
        public PermisoMenuRequest NuevoPermisoMenu { get; set; }
    }
}
