using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.Aplicativos
{
    public static class ActualizarAplicativoDAL
    {
        public static void Execute(AplicativosTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_APLICATIVO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Codigo, objetoTransaccional.AplicativoRequest.Codigo);
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Nombre, objetoTransaccional.AplicativoRequest.Nombre);
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Logo, objetoTransaccional.AplicativoRequest.Logo);
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Estado, objetoTransaccional.AplicativoRequest.Estado);
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Ruta, objetoTransaccional.AplicativoRequest.Ruta);
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Descripcion, objetoTransaccional.AplicativoRequest.Descripcion);
            parametros.Add(PA_INT_ACTUALIZAR_APLICATIVO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_INT_ACTUALIZAR_APLICATIVO.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
            }
        }

    }
}
