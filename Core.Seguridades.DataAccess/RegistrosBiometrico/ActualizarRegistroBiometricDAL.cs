using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Common.Util.Helper.Datos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ActualizarRegistroBiometricDAL
    {
        public static void Execute (RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();

            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.EstadoAnimoCodigo, objetoTransaccional.RegistroBiometricoRequest.EstadoAnimoCodigo);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.NombreRed, objetoTransaccional.RegistroBiometricoRequest.NombreRed);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Codigo, objetoTransaccional.RegistroBiometricoRequest.Codigo);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.FechaRegistro, objetoTransaccional.RegistroBiometricoRequest.FechaRegistro);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraEntrada, TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraEntrada));
            if (objetoTransaccional.RegistroBiometricoRequest.HoraSalida.Equals(ConstantesVariablesSistema.HORA_VACIA))
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraSalida, null);
            }
            else
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraSalida, TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraSalida));
            }
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.IpRegistro, objetoTransaccional.RegistroBiometricoRequest.IpRegistro);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.PcNombre, objetoTransaccional.RegistroBiometricoRequest.PcNombre);
            if (objetoTransaccional.RegistroBiometricoRequest.HoraInicioAlmuerzo.Equals(ConstantesVariablesSistema.HORA_VACIA))
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraInicioAlmuerzo, null);
            }
            else
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraInicioAlmuerzo, TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraInicioAlmuerzo));
            }
            if (objetoTransaccional.RegistroBiometricoRequest.HoraFinAlmuerzo.Equals(ConstantesVariablesSistema.HORA_VACIA))
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraFinAlmuerzo, null);
            }
            else
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraFinAlmuerzo, TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraFinAlmuerzo));
                string VariableSistemaAtraso = VariablesSistemaHelper.ObtenerValor(ConstantesVariablesSistema.TIEMPO_ALMUERZO);
                TimeSpan HoraAtraso = TimeSpan.Parse(VariableSistemaAtraso);
                HoraAtraso = TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraInicioAlmuerzo).Add(TimeSpan.FromMinutes(HoraAtraso.Hours));
                HoraAtraso = TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraFinAlmuerzo) - HoraAtraso;
                if (HoraAtraso.TotalSeconds>0)
                {
                    parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Descripcion, ConstantesVariablesSistema.ALMUERZO_TARDE);
                }
                else
                {
                    parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Descripcion, objetoTransaccional.RegistroBiometricoRequest.Descripcion);
                }
            }
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.TiempoAtraso, objetoTransaccional.RegistroBiometricoRequest.TiempoAtraso);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorBiometrico.NoExisteRegistroBiometricoDia;
            }

        }
    }
}
