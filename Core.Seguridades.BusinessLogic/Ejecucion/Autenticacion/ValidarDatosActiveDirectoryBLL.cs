using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    /// <summary>
    /// Realiza validaciones para los datos de active directory
    /// </summary>
    public static class ValidarDatosActiveDirectoryBLL
    {
        /// <summary>
        /// Valida que los campos no sean nulos o en blanco para la  autentificación mediante active directory
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de autenticacion</param>
        public static void ValidarCamposVaciosAutenticacion(AutenticacionTrx objetoTransaccional)
        {
            if(objetoTransaccional.UsuarioAutenticacionRequest.NombreRedUsuario == null ||
                objetoTransaccional.UsuarioAutenticacionRequest.ContraseniaUsuario == null ||
                objetoTransaccional.UsuarioAutenticacionRequest.NombreRedUsuario == "" ||
                objetoTransaccional.UsuarioAutenticacionRequest.ContraseniaUsuario == "")
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.CamposVaciosActenticacionActiveDirectory;
            }
        }
    }
}
