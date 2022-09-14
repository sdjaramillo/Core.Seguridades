using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Usuarios
{
    public class CumpleanieroMes
    {
        public CumpleanieroMes() { }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
    }
}
