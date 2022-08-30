using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Autenticacion
{
    /// <summary>
    /// Respuesta de la autenticación con active directory
    /// </summary>
    public class AutenticarActiveDirectoryResponse
    {
        public bool InicioSesion { get; set; }
    }
}
