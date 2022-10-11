using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.FuenteImagenes
{
    public class ObtenerListaFuenteImagenRequest
    {
        public ObtenerListaFuenteImagenRequest() { }
        public string Tipo { get; set; }
        public string NombreRed { get; set; }
    }
}
