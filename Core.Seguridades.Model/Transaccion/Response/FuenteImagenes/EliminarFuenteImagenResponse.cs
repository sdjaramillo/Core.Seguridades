using Core.Seguridades.Model.Entidad.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.FuenteImagenes
{
    public class EliminarFuenteImagenResponse
    {
        public EliminarFuenteImagenResponse()
        {
            ImagenEliminada = new Imagen();
        }
        public Imagen ImagenEliminada;
    }
}
