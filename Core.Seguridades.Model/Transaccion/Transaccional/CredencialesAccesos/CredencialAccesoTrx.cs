using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.CredencialesAccesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos
{
    /// <summary>
    /// Objeto transaccional para la entidad credencialAcceso
    /// </summary>
    public class CredencialAccesoTrx : TransaccionBase
    {
        public CredencialAccesoTrx()
        {
            CredencialAcceso = new CredencialAcceso();
        }
        public CredencialAcceso CredencialAcceso { get; set; }
    }
}
