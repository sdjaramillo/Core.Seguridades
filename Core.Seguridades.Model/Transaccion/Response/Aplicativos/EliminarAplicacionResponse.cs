using Core.Seguridades.Model.Entidad.Aplicativos;

namespace Core.Seguridades.Model.Transaccion.Response.Aplicativos
{
    public class EliminarAplicativoResponse
    {
        public EliminarAplicativoResponse()
        {
            EliminarAplicativo = new Aplicativo();
        }
        public Aplicativo EliminarAplicativo { get; set; }
    }
}
