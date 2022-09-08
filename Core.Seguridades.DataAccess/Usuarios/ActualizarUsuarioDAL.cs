using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Core.Seguridades.DataAccess.Usuarios
{
     

    /// <summary>
    /// Lógica de acceso de los datos que permite actualizar un usuario
    /// </summary>
    public static class ActualizarUsuarioDAL
    {
        /// <summary>
        /// Método que ejecuta la actualización de los datos de un usuario en tabla SEG_USUARIO de la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_ACTUALIZAR_USUARIO.NombreStoreProcedure;

            using (var connection = new SqlConnection(new DB_Connection().connDB_name))
            {
                DynamicParameters parametros;
                parametros = new DynamicParameters();
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.CodigoHorarioLaboral, objetoTransaccional.UsuarioRequest.CodigoHorarioLaboral);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.CodigoEmpresa, objetoTransaccional.UsuarioRequest.CodigoEmpresa);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.NombreRed, objetoTransaccional.UsuarioRequest.NombreRed);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Nombres, objetoTransaccional.UsuarioRequest.Nombres);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Apellidos, objetoTransaccional.UsuarioRequest.Apellidos);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Ciudad, objetoTransaccional.UsuarioRequest.Ciudad);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.FechaNacimiento, objetoTransaccional.UsuarioRequest.FechaNacimiento);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.FechaIngreso, objetoTransaccional.UsuarioRequest.FechaIngreso);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.FechaSalida, objetoTransaccional.UsuarioRequest.FechaSalida);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Estado, objetoTransaccional.UsuarioRequest.Estado);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.CorreoElectronico, objetoTransaccional.UsuarioRequest.CorreoElectronico);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Descripcion, objetoTransaccional.UsuarioRequest.Descripcion);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Imagen, objetoTransaccional.UsuarioRequest.Imagen);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

                var resultado = connection.Query(query, parametros, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
