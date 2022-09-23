using Core.Seguridades.Model.Entidad.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
