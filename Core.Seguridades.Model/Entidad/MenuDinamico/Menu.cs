using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.MenuDinamico
{
    public class Menu
    {
        public string MenuCodigo { get; set; }
        public string MenuNombre { get; set; }
        public int Nivel { get; set; }
        public string CodigoPadre { get; set; }
        public string Ruta { get; set; }
        public string OpcionMenuCodigo { get; set; }
        public string OpcionMenuNombre { get; set; }
    }
}
