using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Lógica de ejecución para actualiza un usuario de BD
    /// </summary>
    public static class ActualizarUsuarioBLL
    {
        /// <summary>
        /// Método que actualiza los datos de un usuarios almacenados en la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void ActualizarUsuario(UsuarioTrx objetoTransaccional)
        {
            ActualizarUsuarioDAL.Execute(objetoTransaccional);
        }
    }
}
