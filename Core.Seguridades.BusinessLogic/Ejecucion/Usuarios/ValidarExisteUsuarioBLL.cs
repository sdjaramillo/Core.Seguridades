using Core.Common.Model.ExcepcionServicio;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Realizar validación que el usuario exista
    /// </summary>
    public static class ValidarExisteUsuarioBLL
    {
        /// <summary>
        /// Valida la existencia del usuario por el nombre de usaurio de red
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void ExistenciaUsuarioBaseDatosActualizar(UsuarioTrx objetoTransaccional)
        {
            List<Usuario> listaUsuariosBaseDatos = objetoTransaccional.ListaUsuarios.ToList();
            if (listaUsuariosBaseDatos.Count > 0)
            {
                try
                {
                    var usuarioVerificado = listaUsuariosBaseDatos.Single(x => x.NombreRed == objetoTransaccional.ActualizarUsuarioRequest.NombreRed);
                    objetoTransaccional.Usuario = usuarioVerificado;
                }
                catch
                {
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteUsuariosBaseDatos;
                    //throw new ExcepcionServicio((int)ErrorUsuario.NoExisteUsuariosBaseDatos);
                }
            }
            else {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteUsuariosBaseDatos;
            }
        }
        public static void ExistenciaUsuarioBaseDatosObtener(UsuarioTrx objetoTransaccional)
        {
            List<Usuario> listaUsuariosBaseDatos = objetoTransaccional.ListaUsuarios.ToList();
            if (listaUsuariosBaseDatos.Count > 0)
            {
                try
                {
                    var usuarioVerificado = listaUsuariosBaseDatos.Single(x => x.NombreRed == objetoTransaccional.NombreRed);
                    objetoTransaccional.Usuario = usuarioVerificado;
                }catch
                {
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteUsuariosBaseDatos;
                    //throw new ExcepcionServicio((int)ErrorUsuario.NoExisteUsuariosBaseDatos);
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteUsuariosBaseDatos;
            }
        }
    }
}
