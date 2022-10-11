using Core.Seguridades.Model.Entidad.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.FuenteImagenes
{
    public class ObtenerListaFuenteImagenResponse
    {
        public ObtenerListaFuenteImagenResponse()
        {
            Imagenes = new List<Imagen>();
        }
        public List<Imagen> Imagenes { get; set; }
    }
}
