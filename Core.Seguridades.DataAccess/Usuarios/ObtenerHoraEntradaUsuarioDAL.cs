using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Common.Util.Helper.Datos;
using Core.Seguridades.Model.Entidad.RegistrosBiometrico;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Seguridades.DataAccess.Usuarios.ObtenerListaCumpleaniosDAL;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public static class ObtenerHoraEntradaUsuarioDAL
    {
        internal class PA_SEG_OBTENER_HORA_ENTRADA_Result
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraSalida { get; set; }
            public string Tipo { get; set; }
            public bool Estado { get; set; }
            public bool TiempoAtraso { get; set; }
        }
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_HORA_ENTRADA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_OBTENER_HORA_ENTRADA.NombreRed, objetoTransaccional.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_SEG_OBTENER_HORA_ENTRADA_Result> resultadoListaHorarioLaboral = conexion.ObtenerListaDatos<PA_SEG_OBTENER_HORA_ENTRADA_Result>(query, parametros);

            foreach(var horarioUsuario in resultadoListaHorarioLaboral)
            {
                string VariableSistemaAtraso = VariablesSistemaHelper.ObtenerValor(ConstantesVariablesSistema.TIEMPO_ATRASO_EMPLEADO);
                TimeSpan HoraAtraso = TimeSpan.Parse(VariableSistemaAtraso);
                HoraAtraso = horarioUsuario.HoraEntrada.Add(TimeSpan.FromMinutes(HoraAtraso.Minutes));
                HoraAtraso = DateTime.Now.TimeOfDay - HoraAtraso;
                if (HoraAtraso.TotalSeconds > 0)
                {
                    horarioUsuario.TiempoAtraso = true;
                }
                else
                {
                    horarioUsuario.TiempoAtraso = false;
                }
            }

            objetoTransaccional.HorarioLaboralUsuario.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<HorarioLaboral, PA_SEG_OBTENER_HORA_ENTRADA_Result>(resultadoListaHorarioLaboral));
        }
    }
}
