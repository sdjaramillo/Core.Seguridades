using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Noticias;
using Core.Seguridades.Model.Entidad.Preguntas;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Seguridades.DataAccess.Noticias.ObtenerListaNoticiasDAL;

namespace Core.Seguridades.DataAccess.Preguntas
{
    public static class ObtenerListaPreguntaDAL
    {
        internal class PA_INT_OBTENER_LISTA_PREGUNTAS_Result
        {
            public string CodigoPregunta { get; set; }
            public string Imagen { get; set; }
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public string CodigoRespuesta { get; set; }
            public string Respuesta { get; set; }
            public int Total { get; set; }
        }
        public static void Execute(PreguntaTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_PREGUNTAS.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_LISTA_PREGUNTAS.NombreRed, objetoTransaccional.NombreRedRequest);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_LISTA_PREGUNTAS_Result> resultadoListaPreguntas = conexion.ObtenerListaDatos<PA_INT_OBTENER_LISTA_PREGUNTAS_Result>(query, parametros);

            objetoTransaccional.ListadoPreguntas.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Pregunta, PA_INT_OBTENER_LISTA_PREGUNTAS_Result>(resultadoListaPreguntas));
        }
    }
}
