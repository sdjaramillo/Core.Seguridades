using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.MenuDinamico
{
    public class PermisoMenuRequest
    {
        public PermisoMenuRequest() { }
        public string MenuCodigo { get; set; }
        public string RolCodigo { get; set; }
        public string OpcionMenuCodigo { get; set; }
    }
}
