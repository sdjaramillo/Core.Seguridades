using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.Autenticacion
{
    /// <summary>
    /// Solicitud de datos para autenticar usuario mediante active directory
    /// </summary>
    public class AutenticarActiveDirectoryRequest
    {
        public AutenticarActiveDirectoryRequest() { }
        public string NombreRedUsuario {get; set;}
        public string ContraseniaUsuario { get; set;}
    }
}
