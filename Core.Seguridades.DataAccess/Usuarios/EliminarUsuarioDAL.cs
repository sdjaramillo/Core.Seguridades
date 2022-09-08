using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Core.Seguridades.DataAccess.Usuarios
{
    /// <summary>
    /// Lógica de acceso a los datos que permite eliminar un usaurio
    /// </summary>
    public static class EliminarUsuarioDAL
    {
        /// <summary>
        /// Método que elimina un usuario de la tabla SEG_USUARIO de la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_ELIMINAR_USUARIO.NombreStoreProcedure;

            using (var connection = new SqlConnection(new DB_Connection().connDB_name))
            {

                foreach (var usuario in objetoTransaccional.ListaUsuariosEliminados)
                {
                    DynamicParameters parametros;
                    parametros = new DynamicParameters();
                    parametros.Add(PA_SEG_ELIMINAR_USUARIO.NombreRed, usuario);

                    var resultado = connection.Query(query, parametros, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
