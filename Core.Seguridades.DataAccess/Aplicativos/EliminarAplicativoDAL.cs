using Core.Common.DataAccess.Helper;
using Core.Common.Model.ExcepcionServicio;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Aplicativos
{
    public static class EliminarAplicativoDAL
    {
        public static void Execute(AplicativosTrx objetoTransaccional)
        {
            string query = PA_INT_ELIMINAR_APLICATIVO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ELIMINAR_APLICATIVO.AplicativoCodigo, objetoTransaccional.AplicativoCodigo);
            parametros.Add(PA_INT_ELIMINAR_APLICATIVO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_INT_AGREGAR_IMAGEN.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
                //throw new ExcepcionServicio((int)ErrorAplicativo.NoExisteAplicativoBaseDatos);
            }
        }
    }
}
