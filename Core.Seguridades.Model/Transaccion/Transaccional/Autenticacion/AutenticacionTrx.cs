using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.CredencialesAccesos;
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
        public AutenticacionTrx()
        {
            UsuarioAutenticacionRequest = new AutenticarActiveDirectoryRequest();
            CredencialAcceso = new CredencialAcceso();
        }
        //public string BaseDatos { get; set; }

        /// <summary>
        /// Campos de nombre y contraseña para petición de inicio de sesión
        /// </summary>
        public AutenticarActiveDirectoryRequest UsuarioAutenticacionRequest { get; set; }

        /// <summary>
        /// Resultado de inicio de sesión 
        /// </summary>
        public bool ResultadoAutenticacion { get; set; }

        /// <summary>
        /// Variable para mapear credencial Acceso con otras entidades
        /// </summary>
        public CredencialAcceso CredencialAcceso { get; set; }
    }
}
