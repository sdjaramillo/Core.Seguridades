using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Seguridades.DataAccess.RegistrosBiometrico.ObtenerTotalAtrasosMesDAL;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ObtenerRegistroDiaUsuarioDAL
    {
        internal class PA_INT_OBTENER_REGISTRO_DIA_Result
        {
            public int BiometricoId { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraInicioAlmuerzo { get; set; }
            public TimeSpan HoraFinAlmuerzo { get; set; }
            public TimeSpan HoraSalida { get; set; }
        }
        public static void Execute(RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_REGISTRO_DIA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_REGISTRO_DIA.NombreRed, objetoTransaccional.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_REGISTRO_DIA_Result> resultadoIdBiometrico = conexion.ObtenerListaDatos<PA_INT_OBTENER_REGISTRO_DIA_Result>(query, parametros);

            try
            {
                objetoTransaccional.RegistroBiometricoNuevo.IdRegistroBiometrico = resultadoIdBiometrico.First().BiometricoId;
                objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada = resultadoIdBiometrico.First().HoraEntrada;
                objetoTransaccional.RegistroBiometricoNuevo.HoraInicioAlmuerzo = resultadoIdBiometrico.First().HoraInicioAlmuerzo;
                objetoTransaccional.RegistroBiometricoNuevo.HoraFinAlmuerzo = resultadoIdBiometrico.First().HoraFinAlmuerzo;
                objetoTransaccional.RegistroBiometricoNuevo.HoraSalida = resultadoIdBiometrico.First().HoraSalida;
            }
            catch{
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorBiometrico.NoExisteRegistroBiometricoDia;
            }
            
        }
    }
}
