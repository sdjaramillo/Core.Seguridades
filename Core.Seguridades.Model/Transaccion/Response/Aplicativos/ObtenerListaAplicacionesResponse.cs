using Core.Seguridades.Model.Entidad.Aplicativos;

namespace Core.Seguridades.Model.Transaccion.Response.Aplicativos
{
    public class ObtenerListaAplicativosResponse
    {
        public ObtenerListaAplicativosResponse()
        {
            Aplicativos = new List<Aplicativo>();
        }
        public List<Aplicativo> Aplicativos { get; set; }
    }
}
