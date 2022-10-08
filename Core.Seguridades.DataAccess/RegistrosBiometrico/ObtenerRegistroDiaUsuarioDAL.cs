using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.RegistroBiometrico;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ObtenerRegistroDiaUsuarioDAL
    {
        internal class PA_INT_OBTENER_REGISTRO_DIA_Result
        {
            public int IdRegistroBiometrico { get; set; }
            public string Codigo { get; set; }
            public string NombreRed { get; set; }
            public string EstadoAnimoCodigo { get; set; }
            public string IpRegistro { get; set; }
            public string PcNombre { get; set; }
            public float TiempoAtraso { get; set; }
            public DateTime FechaRegistro { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraInicioAlmuerzo { get; set; }
            public TimeSpan HoraFinAlmuerzo { get; set; }
            public TimeSpan HoraSalida { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_REGISTRO_DIA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_REGISTRO_DIA.NombreRed, objetoTransaccional.NombreRed);


            /*DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_REGISTRO_DIA_Result> resultadoIdBiometrico = conexion.ObtenerListaDatos<PA_INT_OBTENER_REGISTRO_DIA_Result>(query, parametros);

            try
            {
                objetoTransaccional.RegistroBiometricoNuevo.IdRegistroBiometrico = resultadoIdBiometrico.First().BiometricoId;
                objetoTransaccional.RegistroBiometricoNuevo.Codigo = resultadoIdBiometrico.First().Codigo;
                objetoTransaccional.RegistroBiometricoNuevo.UsuarioCodigo = resultadoIdBiometrico.First().UsuarioCodigo;
                objetoTransaccional.RegistroBiometricoNuevo.EstadoAnimoCodigo = resultadoIdBiometrico.First().EstadoAnimo;
                objetoTransaccional.RegistroBiometricoNuevo.IpRegistro = resultadoIdBiometrico.First().IpRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.PcNombre = resultadoIdBiometrico.First().PcNombre;
                objetoTransaccional.RegistroBiometricoNuevo.TiempoAtraso = resultadoIdBiometrico.First().TiempoAtraso;
                objetoTransaccional.RegistroBiometricoNuevo.FechaRegistro = resultadoIdBiometrico.First().FechaRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada = resultadoIdBiometrico.First().HoraEntrada;
                objetoTransaccional.RegistroBiometricoNuevo.HoraInicioAlmuerzo = resultadoIdBiometrico.First().HoraInicioAlmuerzo;
                objetoTransaccional.RegistroBiometricoNuevo.HoraFinAlmuerzo = resultadoIdBiometrico.First().HoraFinAlmuerzo;
                objetoTransaccional.RegistroBiometricoNuevo.HoraSalida = resultadoIdBiometrico.First().HoraSalida;
                objetoTransaccional.RegistroBiometricoNuevo.Descripcion = resultadoIdBiometrico.First().Descripcion;
            }
            catch{
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorBiometrico.NoExisteRegistroBiometricoDia;
            }*/

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_REGISTRO_DIA_Result> resultadoListaBiometrico = conexion.ObtenerListaDatos<PA_INT_OBTENER_REGISTRO_DIA_Result>(query, parametros);

            objetoTransaccional.ListaRegistroBiometrico.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<RegistroBiometrico, PA_INT_OBTENER_REGISTRO_DIA_Result>(resultadoListaBiometrico));
            objetoTransaccional.RegistroBiometricoNuevo = new RegistroBiometrico();
            if (objetoTransaccional.ListaRegistroBiometrico.Count>0)
            {
                objetoTransaccional.RegistroBiometricoNuevo = objetoTransaccional.ListaRegistroBiometrico.First();
            }
        }
    }
}
