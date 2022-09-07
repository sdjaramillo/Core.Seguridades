using Core.Seguridades.Model.Entidad.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.MenuDinamico
{
    public class Permiso
    {
        public string Codigo { get; set; }
        public Menu Menu { get; set; }
        public Rol Rol { get; set; }
        public OpcionMenu OpcionMenu { get; set; }
        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
