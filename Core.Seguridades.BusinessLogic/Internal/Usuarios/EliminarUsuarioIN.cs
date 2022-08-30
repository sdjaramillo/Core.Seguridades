using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    /// <summary>
    /// Logica interna para el proceso de eliminar un usuario de la BD
    /// </summary>
    public class EliminarUsuarioIN : IEliminar<UsuarioTrx, EliminarUsuarioResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);
        }

        public EliminarUsuarioResponse ArmaraPaginaRespuesta(UsuarioTrx objetoTransaccional)
        {
            return null;
        }

        /*public EliminarUsuarioResponse ArmarObjetoRespuesta(UsuarioTrx objetoTransaccional)
        {
            if (objetoTransaccional.Resultado.CodigoRespuesta == (int)Error.OperacionExitosa)
            {
                EliminarUsuarioResponse respuesta = new EliminarUsuarioResponse();
                return MapHelper.MapeoDinamicoRespuesta(objetoTransaccional, respuesta);
            }
            else
                return null;
            return null;
        }*/

        public void Eliminarnformacion(UsuarioTrx objetoTransaccional)
        {
            EliminarUsuarioBBL.EliminarLogicoUsuario(objetoTransaccional);
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            ValidarExisteUsuarioBLL.ExistenciaUsuarioBaseDatos(objetoTransaccional);
        }
    }
}
