using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public static class EliminarUsuarioDAL
    {
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_ELIMINAR_USUARIO.NombreStoreProcedure;

            using (var connection = new SqlConnection(new DB_Connection().connDB_name))
            {
                DynamicParameters parametros;
                parametros = new DynamicParameters();
                parametros.Add(PA_ELIMINAR_USUARIO.NombreRedUsuario, objetoTransaccional.UsuarioRequest.NombreRedUsuario);

                var resultado = connection.Query(query, parametros, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
