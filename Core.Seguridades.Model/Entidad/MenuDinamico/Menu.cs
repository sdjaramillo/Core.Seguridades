using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.MenuDinamico
{
    public class Menu
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Nivel { get; set; }
        public string Ruta { get; set; }
        public string CodigoPadre { get; set; }
    }
}
