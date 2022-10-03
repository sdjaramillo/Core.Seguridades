using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public class ObtenerCumpleanieroDiaDAL
    {
        internal class PA_SEG_OBTENER_CUMPLEANIEROS_DIA_Result
        {
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Imagen { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_CUMPLEANIEROS_DIA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();

            parametros.Add(PA_SEG_OBTENER_CUMPLEANIEROS_DIA.NombreRed, objetoTransaccional.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));

            List<PA_SEG_OBTENER_CUMPLEANIEROS_DIA_Result> resultadoListaCumpleanieros = conexion.ObtenerListaDatos<PA_SEG_OBTENER_CUMPLEANIEROS_DIA_Result>(query, parametros);

            objetoTransaccional.ListaCumpleanierosDia.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<CumpleanieroMes, PA_SEG_OBTENER_CUMPLEANIEROS_DIA_Result>(resultadoListaCumpleanieros));
        }
    }
}
