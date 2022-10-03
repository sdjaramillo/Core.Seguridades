using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.Preguntas
{
    public class PreguntaRequest
    {
        public PreguntaRequest() { }
        public string Codigo { get; set; }
        public string CodigoPermisoPublicacion { get; set; }
        public string Titulo { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public bool Publico { get; set; }
    }
}
