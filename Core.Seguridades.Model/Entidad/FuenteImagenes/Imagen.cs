using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.FuenteImagenes
{
    public class Imagen
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
