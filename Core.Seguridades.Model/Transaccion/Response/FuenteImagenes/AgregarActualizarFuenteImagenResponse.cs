using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Request.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.FuenteImagenes
{
    public class AgregarActualizarFuenteImagenResponse
    {
        public AgregarActualizarFuenteImagenResponse() 
        {
            NuevaImagen = new AgregarActualizarFuenteImagenRequest();
        }
        public AgregarActualizarFuenteImagenRequest NuevaImagen { get; set; }
    }
}
