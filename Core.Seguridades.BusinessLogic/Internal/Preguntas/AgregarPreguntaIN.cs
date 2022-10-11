using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Preguntas;
using Core.Seguridades.Model.Transaccion.Response.Preguntas;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;

namespace Core.Seguridades.BusinessLogic.Internal.Preguntas
{
    public class AgregarPreguntaIN : IInsertar<PreguntaTrx, AgregarPreguntaResponse>
    {
        public void AgregarInformacion(PreguntaTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(PreguntaTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(PreguntaTrx objetoTransaccional)
        {
            AgregarPreguntaBLL.AgregarPregunta(objetoTransaccional);
            ObtenerListaPreguntaBLL.ObtenerListaPregunta(objetoTransaccional);
        }

        public void ValidarInformacion(PreguntaTrx objetoTransaccional)
        {
            ValidarDatosPreguntaBLL.ValidarCamposVaciosPregunta(objetoTransaccional);
        }
    }
}
