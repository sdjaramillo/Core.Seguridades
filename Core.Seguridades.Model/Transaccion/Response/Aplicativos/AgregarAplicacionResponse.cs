using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.Transaccion.Request.Aplicativos;

namespace Core.Seguridades.Model.Transaccion.Response.Aplicativos
{
    public class AgregarAplicativoResponse
    {
        public AgregarAplicativoResponse()
        {
            NuevoAplicativo = new AplicativoRequest();
        }
        public AplicativoRequest NuevoAplicativo { get; set; }
    }
}
