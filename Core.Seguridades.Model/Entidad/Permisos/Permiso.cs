using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Permisos
{
    public class Permiso
    {
        public Permiso() { }
        public int Id { get; set; }
        public string RolCodigo { get; set; }
        public string NombreRed { get;set; }
        public string ProyectoCodigo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
