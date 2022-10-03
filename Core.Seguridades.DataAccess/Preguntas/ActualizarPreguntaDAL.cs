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
    public static class ActualizarPreguntaDAL
    {
        public static void Execute(PreguntaTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_PREGUNTA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.CodigoPregunta, objetoTransaccional.PreguntaRequest.Codigo);
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.CodigoPermisoPublicacion, objetoTransaccional.PreguntaRequest.CodigoPermisoPublicacion);
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.Titulo, objetoTransaccional.PreguntaRequest.Titulo);
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.Imagen, objetoTransaccional.PreguntaRequest.Imagen);
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.Descripcion, objetoTransaccional.PreguntaRequest.Descripcion);
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.Publico, objetoTransaccional.PreguntaRequest.Publico);
            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.Estado, objetoTransaccional.PreguntaRequest.Estado);

            parametros.Add(PA_INT_ACTUALIZAR_PREGUNTA.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_INT_ACTUALIZAR_NOTICIA.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
            }
        }
    }
}
