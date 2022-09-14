using Core.Common.DataAccess.Helper;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class AgregarRegistroBiometricoDAL
    {
        public static void Execute(RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.NombreStoreProcedure;
            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, new DB_Connection().connDB_intranet);
            DynamicParameters parametros;
            parametros = new DynamicParameters();

            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.NombreRed, objetoTransaccional.RegistroBiometricoNuevo.UsuarioCodigo);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.Codigo, objetoTransaccional.RegistroBiometricoNuevo.Codigo);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.FechaRegistro, objetoTransaccional.RegistroBiometricoNuevo.FechaRegistro);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.HoraEntrada, objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.IpRegistro, objetoTransaccional.RegistroBiometricoNuevo.IpRegistro);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.PcNombre, objetoTransaccional.RegistroBiometricoNuevo.PcNombre);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.Atraso, objetoTransaccional.RegistroBiometricoNuevo.TiempoAtraso);
            parametros.Add(PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            var resultado = conexion.InsertarDatos(query, parametros);

            if (parametros.Get<int>(PA_SEG_AGREGAR_LISTA_USUARIOS.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteNombreEmpresaAsignada;
            }
        }
    }
}
