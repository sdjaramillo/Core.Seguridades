using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Permisos
{
    public class PermisoDatosGraficos
    {
        PermisoDatosGraficos() { }
        public string RolCodigo { get; set; }
        public string RolNombre { get; set; }
        public string NombreRed { get; set; }
        public string NombresUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        public string ProyectoCodigo { get; set; }
        public string ProyectoNombre { get; set; }
        public string PermisoCodigo { get; set; }
        public string PermisoNombre { get; set; }
    }
}
