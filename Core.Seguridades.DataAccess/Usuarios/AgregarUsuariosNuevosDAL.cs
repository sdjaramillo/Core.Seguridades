using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace Core.Seguridades.DataAccess.Usuarios
{
    /// <summary>
    /// Lógica de acceso a datos para el proceso de agregar lista de usuarios
    /// </summary>
    public static class AgregarUsuariosNuevosDAL
    {
        /// <summary>
        /// Método que agrega los datos de usuario en la tabla SEG_USUARIO de BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_AGREGAR_LISTA_USUARIOS.NombreStoreProcedure;

            objetoTransaccional.CantidadUsuariosNuevos = objetoTransaccional.ListaUsuariosNuevos.Count;

            using (var connection = new SqlConnection(new DB_Connection().connDB_name))
            {
                DynamicParameters parametros;

                foreach (var usuario in objetoTransaccional.ListaUsuariosNuevos)
                {
                    parametros = new DynamicParameters();
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.NombreRedUsuario, usuario.NombreRedUsuario, System.Data.DbType.String);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.NombresUsuario, usuario.NombreUsuario, System.Data.DbType.String);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.ApellidosUsuario, usuario.ApellidoUsuario, System.Data.DbType.String);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.NombreEmpresa, usuario.NombreEmpresa, System.Data.DbType.String);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.FechaIngresoUsuario, usuario.FechaIngresoUsuario, System.Data.DbType.DateTime);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.CorreoElectronicoUsuario, usuario.CorreoElectronicoUsuario, System.Data.DbType.String);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.CiudadUsuario, usuario.CiudadUsuario, System.Data.DbType.String);
                    parametros.Add(PA_SEG_AGREGAR_LISTA_USUARIOS.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

                    var resultado = connection.Query(query, parametros, commandType: CommandType.StoredProcedure);

                    if (parametros.Get<int>(PA_SEG_AGREGAR_LISTA_USUARIOS.Retorno) != 10000)
                    {
                        objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteNombreEmpresaAsignada;
                        objetoTransaccional.CantidadUsuariosNuevos -= 1;
                    }

                }
            }
        }
    }
}
