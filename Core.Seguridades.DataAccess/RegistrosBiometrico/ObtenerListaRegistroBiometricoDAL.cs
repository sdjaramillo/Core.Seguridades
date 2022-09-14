using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.RegistroBiometrico;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ObtenerListaRegistroBiometricoDAL
    {
        internal class PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO_Result
        {
            public string EstadoAnimoCodigo { get; set; }
            public string UsuarioCodigo { get; set; }
            public string Codigo { get; set; }
            public DateTime FechaRegistro { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraSalida { get; set; }
            public string IpRegistro { get; set; }
            public string PcNombre { get; set; }
            public TimeSpan HoraInicioAlmuerzo { get; set; }
            public TimeSpan HoraFinAlmuerzo { get; set; }
            public float TiempoAtraso { get; set; }
            public string Descripcion { get; set; }
        }

        public static void Execute(RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO.NombreRed, objetoTransaccional.RegistroBiometricoRequest.NombreRed);
            
            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, new DB_Connection().connDB_intranet);
            List<PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO_Result> resultadoListaRegistroBiometrico = conexion.ObtenerListaDatos<PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO_Result>(query,parametros);

            objetoTransaccional.ListaRegistroBiometrico.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<RegistroBiometrico, PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO_Result>(resultadoListaRegistroBiometrico));
        }
    }
}
