using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Core.Seguridades.DataAccess.FuenteImagenes
{
    public static class EliminarFuenteImagenDAL
    {
        public static void Execute(ImagenesTrx objetoTransaccional)
        {
            string query = PA_INT_ELIMINAR_IMAGEN.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ELIMINAR_IMAGEN.ImagenCodigo, objetoTransaccional.ImagenCodigo);
            parametros.Add(PA_INT_ELIMINAR_IMAGEN.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_INT_ELIMINAR_IMAGEN.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorImagen.NoExisteImagenBaseDatos;
            }
        }
    }
}
