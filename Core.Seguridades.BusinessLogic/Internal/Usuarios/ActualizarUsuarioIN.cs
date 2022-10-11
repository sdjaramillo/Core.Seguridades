using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;


namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    /// <summary>
    /// Logica interna para el proceso de actualizar datos de un usuario de la BD
    /// </summary>
    public class ActualizarUsuarioIN : IActualizar<UsuarioTrx, ActualizarUsuarioResponse>
    {
        public void ActualizarInformacion(UsuarioTrx objetoTransaccional)
        {
            ActualizarUsuarioBLL.ActualizarUsuario(objetoTransaccional);
        }

        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);
        }

        public void HomologarInformacion(UsuarioTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            ValidarExisteUsuarioBLL.ExistenciaUsuarioBaseDatosActualizar(objetoTransaccional);
        }
    }
}
