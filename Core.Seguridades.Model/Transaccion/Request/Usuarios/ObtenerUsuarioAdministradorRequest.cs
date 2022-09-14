using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.Usuarios
{
    public class ObtenerUsuarioAdministradorRequest
    {
        public ObtenerUsuarioAdministradorRequest() { }
        public string NombreRed { get; set; }
        public string ProyectoCodigo { get; set; }
    }
}
