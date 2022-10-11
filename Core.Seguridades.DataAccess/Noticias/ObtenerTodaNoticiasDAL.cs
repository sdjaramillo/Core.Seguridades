using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.Entidad.Noticias;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Seguridades.DataAccess.Aplicativos.ObtenerTodaAplicativosDAL;

namespace Core.Seguridades.DataAccess.Noticias
{
    public static class ObtenerTodaNoticiasDAL
    {
        internal class PA_INT_OBTENER_LISTA_TODOS_NOTICIAS_Result
        {
            public string Codigo { get; set; }
            public string Imagen { get; set; }
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(NoticiaTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_TODOS_NOTICIAS.NombreStoreProcedure;

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_LISTA_TODOS_NOTICIAS_Result> resultadoListaNoticias = conexion.ObtenerListaDatos<PA_INT_OBTENER_LISTA_TODOS_NOTICIAS_Result>(query);

            objetoTransaccional.ListadoNoticias.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Noticia, PA_INT_OBTENER_LISTA_TODOS_NOTICIAS_Result>(resultadoListaNoticias));
        }
    }
}
