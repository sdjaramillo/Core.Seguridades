using Core.Seguridades.Model.Entidad.Preguntas;

namespace Core.Seguridades.Model.Transaccion.Response.Preguntas
{
    public class ObtenerListaPreguntaResponse
    {
        public ObtenerListaPreguntaResponse()
        {
            Preguntas = new List<Pregunta>();
        }
        public List<Pregunta> Preguntas { get; set; }
    }
}
