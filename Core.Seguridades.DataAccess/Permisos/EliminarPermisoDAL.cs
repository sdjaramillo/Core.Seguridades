

using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.Permisos
{
    public static class EliminarPermisoDAL
    {
        public static void Execute(PermisoTrx objetoTransaccional) 
        {
            string query = PA_SEG_ELIMINAR_PERMISOS.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();

            parametros.Add(PA_SEG_ELIMINAR_PERMISOS.PermisoCodigo, objetoTransaccional.PermisoCodigo);
            parametros.Add(PA_SEG_ELIMINAR_PERMISOS.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_SEG_ELIMINAR_PERMISOS.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPermiso.NoExistePermisoBaseDatos;
                //throw new ExcepcionServicio((int)ErrorAplicativo.NoExisteAplicativoBaseDatos);
            }
        }
    }
}
