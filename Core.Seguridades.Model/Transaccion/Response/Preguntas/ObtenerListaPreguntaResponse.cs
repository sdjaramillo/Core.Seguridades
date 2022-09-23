using Core.Seguridades.Model.Entidad.Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Preguntas
{
    public class ObtenerListaPreguntaResponse
    {
        public ObtenerListaPreguntaResponse()
        {
            ListaPregunta = new List<Pregunta>();
        }
        public List<Pregunta> ListaPregunta { get; set; }
    }
}
