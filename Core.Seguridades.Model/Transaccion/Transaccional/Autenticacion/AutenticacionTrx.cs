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
    public class AutenticacionTrx : TransaccionBase
    {
        public AutenticarActiveDirectoryRequest UsuarioAutenticacionRequest { get; set; }
        public string MensajeAutenticacion { get; set; }
        public bool ResultadoAutenticacion { get; set; }

    }
}
