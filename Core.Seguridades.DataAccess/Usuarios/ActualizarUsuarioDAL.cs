using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
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

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            DynamicParameters parametros;
                parametros = new DynamicParameters();
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.CodigoHorarioLaboral, objetoTransaccional.ActualizarUsuarioRequest.CodigoHorarioLaboral);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.CodigoEmpresa, objetoTransaccional.ActualizarUsuarioRequest.CodigoEmpresa);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.NombreRed, objetoTransaccional.ActualizarUsuarioRequest.NombreRed);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Nombres, objetoTransaccional.ActualizarUsuarioRequest.Nombres);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Apellidos, objetoTransaccional.ActualizarUsuarioRequest.Apellidos);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Ciudad, objetoTransaccional.ActualizarUsuarioRequest.Ciudad);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.FechaNacimiento, objetoTransaccional.ActualizarUsuarioRequest.FechaNacimiento);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.FechaIngreso, objetoTransaccional.ActualizarUsuarioRequest.FechaIngreso);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.FechaSalida, objetoTransaccional.ActualizarUsuarioRequest.FechaSalida);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Estado, objetoTransaccional.ActualizarUsuarioRequest.Estado);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.CorreoElectronico, objetoTransaccional.ActualizarUsuarioRequest.CorreoElectronico);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Descripcion, objetoTransaccional.ActualizarUsuarioRequest.Descripcion);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Imagen, objetoTransaccional.ActualizarUsuarioRequest.Imagen);
                parametros.Add(PA_SEG_ACTUALIZAR_USUARIO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

                conexion.Actualizar(query, parametros);

            

        }
    }
}
