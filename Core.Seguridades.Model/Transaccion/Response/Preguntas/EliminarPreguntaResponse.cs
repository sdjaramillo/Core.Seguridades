using Core.Seguridades.Model.Entidad.Preguntas;

namespace Core.Seguridades.Model.Transaccion.Response.Preguntas
{
    public class EliminarPreguntaResponse
    {
        public EliminarPreguntaResponse()
        {
            PreguntaEliminada = new Pregunta();
        }
        public Pregunta PreguntaEliminada { get; set; }
    }
}
