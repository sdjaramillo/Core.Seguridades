using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    public class ObtenerUsuarioAdministradorIN : IObtener<UsuarioTrx, ObtenerUsuarioAdministradorResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuarioAdministradorBLL.ObtenerUsuarioAdministrador(objetoTransaccional);
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            
        }
    }
}
