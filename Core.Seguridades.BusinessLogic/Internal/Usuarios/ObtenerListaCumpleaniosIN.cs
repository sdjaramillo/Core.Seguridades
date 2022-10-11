using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    public class ObtenerListaCumpleaniosIN : IObtenerTodos<UsuarioTrx, ObtenerListaCumpleaniosResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerListaCumpleaniosBLL.ObtenerListaCumpleanios(objetoTransaccional);
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            
        }
    }
}
