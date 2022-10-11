using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using Dapper;
using System.Data;


namespace Core.Seguridades.DataAccess.FuenteImagenes
{
    public static class ActualizarFuenteImagenDAL
    {
        public static void Execute (ImagenesTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_IMAGEN.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Codigo, objetoTransaccional.NuevaImagenRequest.Codigo);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.EmpresaCodigo, objetoTransaccional.NuevaImagenRequest.EmpresaCodigo);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Nombre, objetoTransaccional.NuevaImagenRequest.Nombre);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Tipo, objetoTransaccional.NuevaImagenRequest.Tipo);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Valor, objetoTransaccional.NuevaImagenRequest.Valor);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Estado, objetoTransaccional.NuevaImagenRequest.Estado);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.FechaCreacion, objetoTransaccional.NuevaImagenRequest.FechaCreacion);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.FechaCaducidad, objetoTransaccional.NuevaImagenRequest.FechaCaducidad);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Descripcion, objetoTransaccional.NuevaImagenRequest.Descripcion);
            parametros.Add(PA_INT_ACTUALIZAR_IMAGEN.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_INT_ACTUALIZAR_IMAGEN.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorImagen.NoExisteImagenBaseDatos;
            }
        }
    }
}
