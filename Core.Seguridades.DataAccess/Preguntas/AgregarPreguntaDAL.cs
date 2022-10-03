using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.Preguntas
{
    public static class AgregarPreguntaDAL
    {
        internal class PA_INT_AGREGAR_PREGUNTA_Result
        {
            public string CodigoPermisoPublicacion { get; set; }
            public string Codigo { get; set; }
            public string Titulo { get; set; }
            public string Imagen { get; set; }
            public string Descripcion { get; set; }
            public bool Publico { get; set; }
        }
        public static void Execute (PreguntaTrx objetoTransaccional)
        {
            string query = PA_INT_AGREGAR_PREGUNTA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.CodigoPermisoPublicacion, objetoTransaccional.PreguntaRequest.CodigoPermisoPublicacion);
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.Codigo, objetoTransaccional.PreguntaRequest.Codigo);
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.Titulo, objetoTransaccional.PreguntaRequest.Titulo);
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.Imagen, objetoTransaccional.PreguntaRequest.Imagen);
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.Descripcion, objetoTransaccional.PreguntaRequest.Descripcion);
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.Publico, objetoTransaccional.PreguntaRequest.Publico);
            parametros.Add(PA_INT_AGREGAR_PREGUNTA.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));

            conexion.InsertarDatos(query, parametros);

            if (parametros.Get<int>(PA_INT_AGREGAR_NOTICIA.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorNoticia.NoExistePermisoPublicacion;
            }
        }
    }
}
