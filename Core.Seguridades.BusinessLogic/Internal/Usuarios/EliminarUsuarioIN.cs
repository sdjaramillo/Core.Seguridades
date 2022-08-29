using Core.Common.BusinessLogic.ProcessTemplate;
using Core.Common.Model.General;
using Core.Common.Util.Helper;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    public class EliminarUsuarioIN : IEliminar<UsuarioTrx, EliminarUsuarioResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);
            ValidarExisteUsuarioBLL.ExistenciaUsuarioBaseDatos(objetoTransaccional);
        }

        public EliminarUsuarioResponse ArmaraPaginaRespuesta(UsuarioTrx objetoTransaccional)
        {
            return null;
        }

        public EliminarUsuarioResponse ArmarObjetoRespuesta(UsuarioTrx objetoTransaccional)
        {
            /*if (objetoTransaccional.Resultado.CodigoRespuesta == (int)Error.OperacionExitosa)
            {
                EliminarUsuarioResponse respuesta = new EliminarUsuarioResponse();
                return MapHelper.MapeoDinamicoRespuesta(objetoTransaccional, respuesta);
            }
            else
                return null;*/
            return null;
        }

        public void Eliminarnformacion(UsuarioTrx objetoTransaccional)
        {
            EliminarUsuarioBBL.EliminarLogicoUsuario(objetoTransaccional);
        }
    }
}
