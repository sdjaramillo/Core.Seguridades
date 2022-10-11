using Core.Seguridades.Model.Transaccion.Request.Aplicativos;

namespace Core.Seguridades.Model.Transaccion.Response.Aplicativos
{
    public class ActualizarAplicativoResponse
    {
        public ActualizarAplicativoResponse()
        {
            AplicativoActualizado = new AplicativoRequest();
        }
        public AplicativoRequest AplicativoActualizado { get; set; }
    }
}
