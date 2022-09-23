using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Noticias
{
    public static class EliminarNoticiaDAL
    {
        public static void Execute (NoticiaTrx objetoTransaccional)
        {
            string query = PA_INT_ELIMINAR_NOTICIA.NombreStoreProcedure;
            
            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ELIMINAR_NOTICIA.CodigoNoticia, objetoTransaccional.CodigoNoticia);
            parametros.Add(PA_INT_ELIMINAR_APLICATIVO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_INT_ELIMINAR_NOTICIA.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorNoticia.NoExisteNoticiaBaseDatos;
            }
        }
    }
}
