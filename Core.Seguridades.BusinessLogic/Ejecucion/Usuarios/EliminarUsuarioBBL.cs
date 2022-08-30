using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Lógica de ejecución para eliminar a un usuarios en la BD
    /// </summary>
    public static class EliminarUsuarioBBL
    {
        /// <summary>
        /// Método que elimina un usuario almacenado en la BD de forma lógica
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void EliminarLogicoUsuario(UsuarioTrx objetoTransaccional)
        {
            EliminarUsuarioDAL.Execute(objetoTransaccional);
        }
    }
}
