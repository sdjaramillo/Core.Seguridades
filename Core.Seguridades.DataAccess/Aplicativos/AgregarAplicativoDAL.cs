using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.Aplicativos
{
    public static class AgregarAplicativoDAL
    {
        internal class PA_INT_AGREGAR_APLICATIVO_Result
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Logo { get; set; }
            public string Ruta { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(AplicativosTrx objetoTransaccional)
        {
            string query = PA_INT_AGREGAR_APLICATIVO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_AGREGAR_APLICATIVO.Codigo, objetoTransaccional.AplicativoRequest.Codigo);
            parametros.Add(PA_INT_AGREGAR_APLICATIVO.Nombre, objetoTransaccional.AplicativoRequest.Nombre);
            parametros.Add(PA_INT_AGREGAR_APLICATIVO.Logo, objetoTransaccional.AplicativoRequest.Logo);
            parametros.Add(PA_INT_AGREGAR_APLICATIVO.Ruta, objetoTransaccional.AplicativoRequest.Ruta);
            parametros.Add(PA_INT_AGREGAR_APLICATIVO.Descripcion, objetoTransaccional.AplicativoRequest.Descripcion);
            parametros.Add(PA_INT_AGREGAR_APLICATIVO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.InsertarDatos(query, parametros);

        }
    }
}
