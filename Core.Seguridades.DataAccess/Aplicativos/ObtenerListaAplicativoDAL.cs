using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using Dapper;

namespace Core.Seguridades.DataAccess.Aplicativos
{
    public static class ObtenerListaAplicativoDAL
    {
        internal class PA_INT_OBTENER_LISTA_APLICATIVOS_Result
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Logo { get; set; }
            public string Ruta { get; set; }
        }
        public static void Execute(AplicativosTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_APLICATIVOS.NombreStoreProcedure;
            
            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_LISTA_APLICATIVOS.CodigoEmpresa, objetoTransaccional.CodigoEmpresa);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_LISTA_APLICATIVOS_Result> resultadoListaAplicativos = conexion.ObtenerListaDatos<PA_INT_OBTENER_LISTA_APLICATIVOS_Result>(query, parametros);

            objetoTransaccional.ListadoAplicativos.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Aplicativo, PA_INT_OBTENER_LISTA_APLICATIVOS_Result>(resultadoListaAplicativos));
        }
    }
}
