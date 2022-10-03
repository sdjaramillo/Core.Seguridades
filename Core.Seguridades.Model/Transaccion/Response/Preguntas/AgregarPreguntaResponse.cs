using Core.Seguridades.Model.Transaccion.Request.Preguntas;

namespace Core.Seguridades.Model.Transaccion.Response.Preguntas
{
    public class AgregarPreguntaResponse
    {
        public AgregarPreguntaResponse()
        {
            NuevaPregunta = new PreguntaRequest();
        }
        public PreguntaRequest NuevaPregunta { get; set; }
    }
}
