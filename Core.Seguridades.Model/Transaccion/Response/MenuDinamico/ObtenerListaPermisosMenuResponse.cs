using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.MenuDinamico
{
    public class ObtenerListaPermisosMenuResponse
    {
        public ObtenerListaPermisosMenuResponse() { }
        public string MenuCodigo { get; set; }
        public string RolCodigo { get; set; }
        public string OpcionMenuCodigo { get; set; }
        public string MenuNombre { get; set; }
        public string RolNombre { get; set; }
        public string OpcionMenuNombre { get; set; }
    }
}
