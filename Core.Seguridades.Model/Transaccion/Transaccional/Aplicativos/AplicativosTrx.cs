using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.Transaccion.Request.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos
{
    public class AplicativosTrx : TransaccionBase
    {
        public AplicativosTrx()
        {
            ListadoAplicativos = new List<Aplicativo>();
            AplicativoRequest = new AplicativoRequest();
            AplicativoCodigo = "";
            NombreRed = "";
            AplicativoValido = new Aplicativo();
        }
        public List<Aplicativo> ListadoAplicativos { get; set; }
        public string AplicativoCodigo { get; set; }
        public string NombreRed { get; set; }
        public AplicativoRequest AplicativoRequest { get; set; }
        public Aplicativo AplicativoValido { get; set; }
    }
}
