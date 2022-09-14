using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Realiza validaciones para los usuarios
    /// </summary>
    public static class ValidarDatosUsuarioBLL
    {
        /// <summary>
        /// Valida que cualquiera de los 6 campos de los usuarios no sean null
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void ValidarParametrosVacios (UsuarioTrx objetoTransaccional)
        {
            List<UsuarioActiveDirectory> UsuariosInvalidos = new List<UsuarioActiveDirectory>();
            foreach (var usuario in objetoTransaccional.ListaUsuariosNuevos)
            {
                if (usuario.NombreEmpresa == null ||
                    usuario.ApellidoUsuario == null ||
                    usuario.CadenaNombreEmpresa == null ||
                    usuario.NombreEmpresa == null ||
                    usuario.CorreoElectronicoUsuario == null )
                {
                    UsuariosInvalidos.Add(usuario);
                }
                else
                {
                    objetoTransaccional.CantidadUsuariosNuevos -= 1;
                }
            }
            objetoTransaccional.ListaUsuariosNuevos = objetoTransaccional.ListaUsuariosNuevos.Except(UsuariosInvalidos).ToList();
        }
        
    }
}
