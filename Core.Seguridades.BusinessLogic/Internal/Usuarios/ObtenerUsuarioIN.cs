using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    public class ObtenerUsuarioIN : IObtener<UsuarioTrx, ObtenerUsuarioResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerUsuario(objetoTransaccional);
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            
        }
    }
}
