using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.Autenticacion
{
    public class GenerarTokenRequest
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}
