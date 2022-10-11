using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.Entidad.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Noticias
{
    public class ActualizarNoticiaResponse
    {
        public ActualizarNoticiaResponse()
        {
            Noticias = new List<Noticia>();
        }
        public List<Noticia> Noticias { get; set; }
    }
}
