using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Preguntas
{
    public static class EliminarPreguntaDAL
    {
        public static void Execute(PreguntaTrx objetoTransaccional)
        {
            string query = PA_INT_ELIMINAR_PREGUNTA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ELIMINAR_PREGUNTA.CodigoPregunta, objetoTransaccional.CodigoPregunta);
            parametros.Add(PA_INT_ELIMINAR_PREGUNTA.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_INT_ELIMINAR_PREGUNTA.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPregunta.NoExistePreguntaBaseDatos; ;
            }
        }
    }
}
