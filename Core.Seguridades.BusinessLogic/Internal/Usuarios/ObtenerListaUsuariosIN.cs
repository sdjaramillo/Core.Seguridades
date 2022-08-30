using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    /// <summary>
    /// Logica interna para el proceso de obtener la lista de usuarios
    /// </summary>
    public class ObtenerListaUsuariosIN : IObtenerTodos<UsuarioTrx, ObtenerListaUsuariosResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
        }

        public ObtenerListaUsuariosResponse ArmaraPaginaRespuesta(UsuarioTrx objetoTransaccional)
        {
            return null;
        }

        /*public ObtenerListaUsuariosResponse ArmarObjetoRespuesta(UsuarioTrx objetoTransaccional)
        {
            if (objetoTransaccional.Resultado.CodigoRespuesta == (int)Error.OperacionExitosa)
            {
                ObtenerListaUsuariosResponse respuesta = new ObtenerListaUsuariosResponse();
                return respuesta;
            }
            else
                return null;
        }*/
    }
}
