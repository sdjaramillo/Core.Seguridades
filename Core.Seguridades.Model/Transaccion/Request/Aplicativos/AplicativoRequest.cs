using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.Aplicativos
{
    public class AplicativoRequest
    {
        public AplicativoRequest() { }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }
        public bool Estado { get; set; }
        public string Ruta { get; set; }
        public string Descripcion { get; set; }
    }
}
