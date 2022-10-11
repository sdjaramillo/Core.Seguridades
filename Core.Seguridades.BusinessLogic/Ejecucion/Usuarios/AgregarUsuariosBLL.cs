using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Lógica de ejecución para agregar usuarios
    /// </summary>
    public static class AgregarUsuariosBLL
    {
        /// <summary>
        /// Método para agrega una lista de usuarios nuevos en la BD 
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void AgregarListaUsuariosNuevos(UsuarioTrx objetoTransaccional) {

            AgregarUsuariosNuevosDAL.Execute(objetoTransaccional);
        }

        /// <summary>
        /// Método para agrega un usuario nuevo en la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void AgregarUsuarioNuevo(UsuarioTrx objetoTransaccional)
        { 
        
        
        
        }

    }
}
