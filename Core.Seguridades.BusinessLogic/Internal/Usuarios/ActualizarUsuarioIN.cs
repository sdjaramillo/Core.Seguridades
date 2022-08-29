using Core.Common.BusinessLogic.ProcessTemplate;
using Core.Common.Model.General;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;


namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    public class ActualizarUsuarioIN : IActualizar<UsuarioTrx, ActualizarUsuarioResponse>
    {
        public void ActualizarInformacion(UsuarioTrx objetoTransaccional)
        {
            ActualizarUsuarioBLL.ActualizarUsuario(objetoTransaccional);
            //throw new NotImplementedException();
        }

        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);
        }

        public ActualizarUsuarioResponse ArmaraPaginaRespuesta(UsuarioTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
            return null;
        }

        public ActualizarUsuarioResponse ArmarObjetoRespuesta(UsuarioTrx objetoTransaccional)
        {
            if (objetoTransaccional.Resultado.CodigoRespuesta == (int)Error.OperacionExitosa)
            {
                ActualizarUsuarioResponse respuesta = new ActualizarUsuarioResponse();
                return respuesta;
            }
            else
                return null;
        }

        public void HomologarInformacion(UsuarioTrx objetoTransaccional)
        {
            //throw new NotImplementedException();
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            ValidarExisteUsuarioBLL.ExistenciaUsuarioBaseDatos(objetoTransaccional);
        }
    }
}
