using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public static class ObtenerUsuarioDAL
    {
        internal class PA_OBTENER_LISTA_USUARIOS_Result
        {
            public int Id { get; set; }
            public string CodigoHorarioLaboral { get; set; }
            public string CodigoEmpresa { get; set; }
            public string NombreRed { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Ciudad { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaSalida { get; set; }
            public string Imagen { get; set; }
            public string CorreoElectronico { get; set; }
            public Boolean Estado { get; set; }
            public string Descripcion { get; set; }

        }

        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_USUARIO.NombreStoreProcedure;
            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_OBTENER_USUARIO.NombreRed, objetoTransaccional.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_OBTENER_LISTA_USUARIOS_Result> resultadoListaUsuarios = conexion.ObtenerListaDatos<PA_OBTENER_LISTA_USUARIOS_Result>(query,parametros);


            objetoTransaccional.ListaUsuarios.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Usuario, PA_OBTENER_LISTA_USUARIOS_Result>(resultadoListaUsuarios));
            objetoTransaccional.Usuario = objetoTransaccional.ListaUsuarios.First();
        }
    }
}
