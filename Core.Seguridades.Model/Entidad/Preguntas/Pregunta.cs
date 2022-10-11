using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Preguntas
{
    public class Pregunta
    {
        public Pregunta() { }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public bool Estado { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
    }
}
