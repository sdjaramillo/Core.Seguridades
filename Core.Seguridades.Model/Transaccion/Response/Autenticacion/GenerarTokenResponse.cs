using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Autenticacion
{
    public class GenerarTokenResponse
    {
        /// <summary>
        /// JWT Token de autenticación
        /// </summary>
        public string TokenJWT { get; set; }          
    }
}
