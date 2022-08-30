using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Transaccion.Request.Autenticacion;
using Core.Seguridades.Model.Transaccion.Request.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion
{
    /// <summary>
    /// Objeto transaccional para autenticar
    /// </summary>
    public class AutenticacionTrx : TransaccionBase
    {
        /// <summary>
        /// Campos de nombre y contraseña para petición de inicio de sesión
        /// </summary>
        public AutenticarActiveDirectoryRequest UsuarioAutenticacionRequest { get; set; }

        /// <summary>
        /// Resultado de inicio de sesión 
        /// </summary>
        public bool ResultadoAutenticacion { get; set; }

    }
}
