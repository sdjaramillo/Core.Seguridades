using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public static class ActualizarUsuarioDAL
    {
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_ACTUALIZAR_USUARIO.NombreStoreProcedure;

            using (var connection = new SqlConnection(new DB_Connection().connDB_name))
            {
                DynamicParameters parametros;
                parametros = new DynamicParameters();
                parametros.Add(PA_ACTUALIZAR_USUARIO.CodigoHorarioLaboral, objetoTransaccional.UsuarioRequest.CodigoHorarioLaboral);
                parametros.Add(PA_ACTUALIZAR_USUARIO.CodigoRol, objetoTransaccional.UsuarioRequest.CodigoRol);
                parametros.Add(PA_ACTUALIZAR_USUARIO.CodigoEmpresa, objetoTransaccional.UsuarioRequest.CodigoEmpresa);
                parametros.Add(PA_ACTUALIZAR_USUARIO.NombreRedUsuario, objetoTransaccional.UsuarioRequest.NombreRedUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.NombreUsuario, objetoTransaccional.UsuarioRequest.NombreUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.ApellidoUsuario, objetoTransaccional.UsuarioRequest.ApellidoUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.FechaNacimientoUsuario, objetoTransaccional.UsuarioRequest.FechaNacimientoUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.FechaIngresoUsuario, objetoTransaccional.UsuarioRequest.FechaIngresoUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.FechaSalidaUsuario, objetoTransaccional.UsuarioRequest.FechaSalidaUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.EstadoUsuario, objetoTransaccional.UsuarioRequest.EstadoUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.CorreoElectronicoUsuario, objetoTransaccional.UsuarioRequest.CorreoElectronicoUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.DescripcionUsuario, objetoTransaccional.UsuarioRequest.DescripcionUsuario);
                parametros.Add(PA_ACTUALIZAR_USUARIO.ImagenUsuario, objetoTransaccional.UsuarioRequest.ImagenUsuario);

                var resultado = connection.Query(query, parametros, commandType: CommandType.StoredProcedure);

                
            }
        }
    }
}
