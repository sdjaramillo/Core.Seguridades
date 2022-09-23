using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ActualizarRegistroBiometricDAL
    {
        public static void Execute (RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();

            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.EstadoAnimoCodigo, objetoTransaccional.ActualizarRegistroBiometrico.EstadoAnimoCodigo);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.NombreRed, objetoTransaccional.ActualizarRegistroBiometrico.NombreRed);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Codigo, objetoTransaccional.ActualizarRegistroBiometrico.Codigo);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.FechaRegistro, objetoTransaccional.ActualizarRegistroBiometrico.FechaRegistro);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraEntrada, TimeSpan.Parse(objetoTransaccional.ActualizarRegistroBiometrico.HoraEntrada));
            if (objetoTransaccional.ActualizarRegistroBiometrico.HoraSalida.Equals("NULL"))
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraSalida, null);
            }
            else
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraSalida, TimeSpan.Parse(objetoTransaccional.ActualizarRegistroBiometrico.HoraSalida));
            }
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.IpRegistro, objetoTransaccional.ActualizarRegistroBiometrico.IpRegistro);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.PcNombre, objetoTransaccional.ActualizarRegistroBiometrico.PcNombre);
            if (objetoTransaccional.ActualizarRegistroBiometrico.HoraInicioAlmuerzo.Equals("NULL"))
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraInicioAlmuerzo, null);
            }
            else
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraInicioAlmuerzo, TimeSpan.Parse(objetoTransaccional.ActualizarRegistroBiometrico.HoraInicioAlmuerzo));
            }
            if (objetoTransaccional.ActualizarRegistroBiometrico.HoraFinAlmuerzo.Equals("NULL"))
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraFinAlmuerzo, null);
            }
            else
            {
                parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.HoraFinAlmuerzo, TimeSpan.Parse(objetoTransaccional.ActualizarRegistroBiometrico.HoraFinAlmuerzo));
            }
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.TiempoAtraso, objetoTransaccional.ActualizarRegistroBiometrico.TiempoAtraso);
            parametros.Add(PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO.Descripcion, objetoTransaccional.ActualizarRegistroBiometrico.Descripcion);
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
