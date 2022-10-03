using Core.Seguridades.Model.Entidad.Preguntas;
using Core.Seguridades.Model.Transaccion.Request.Preguntas;

namespace Core.Seguridades.Model.Transaccion.Response.Preguntas
{
    public class ActualizarPreguntaResponse
    {
        public ActualizarPreguntaResponse()
        {
            PreguntaActualizada = new PreguntaRequest();
        }
        public PreguntaRequest PreguntaActualizada { get; set; }
    }
}
