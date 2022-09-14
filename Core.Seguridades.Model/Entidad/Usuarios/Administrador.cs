using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Usuarios
{
    public class Administrador
    {
        public Administrador() { }
        public bool RolAdministrador { get; set; }
        public bool RolSuperAdministrador { get; set; }
    }
}
