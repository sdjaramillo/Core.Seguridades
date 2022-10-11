using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Aplicativos
{
    public static class ObtenerTodaAplicativosDAL
    {
        internal class PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS_Result
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Logo { get; set; }
            public string Ruta { get; set; }
        }
        public static void Execute(AplicativosTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS.NombreStoreProcedure;

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS_Result> resultadoListaAplicativo = conexion.ObtenerListaDatos<PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS_Result>(query);

            objetoTransaccional.ListadoAplicativos.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Aplicativo, PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS_Result>(resultadoListaAplicativo));
        }
    }
}
