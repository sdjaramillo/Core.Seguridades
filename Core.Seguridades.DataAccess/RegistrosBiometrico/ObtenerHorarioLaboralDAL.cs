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

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ObtenerHorarioLaboralDAL
    {
        internal class PA_SEG_OBTENER_HORA_ENTRADA_Result
        {
            public TimeSpan HoraEntrada { get; set; }
            public bool Estado { get; set; }
        }
        public static void Execute(RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_HORA_ENTRADA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();

            parametros.Add(PA_SEG_OBTENER_HORA_ENTRADA.NombreRed, objetoTransaccional.RegistroBiometricoNuevoRequest.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_SEG_OBTENER_HORA_ENTRADA_Result> resultadoHorarioLaboral = conexion.ObtenerListaDatos<PA_SEG_OBTENER_HORA_ENTRADA_Result>(query, parametros);

            objetoTransaccional.HoraEntradaEstablecida.HoraEntrada = resultadoHorarioLaboral.First().HoraEntrada;
            objetoTransaccional.HoraEntradaEstablecida.Estado = resultadoHorarioLaboral.First().Estado;
        }
    }
}
