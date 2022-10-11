using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Noticias
{
    public class Noticia
    {
        public Noticia() { }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
    }
}
