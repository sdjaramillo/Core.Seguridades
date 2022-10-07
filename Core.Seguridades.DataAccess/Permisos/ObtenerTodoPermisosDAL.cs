using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.Entidad.Permisos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.DataAccess.Permisos
{
    public static class ObtenerTodoPermisosDAL
    {
        internal class PA_SEG_OBTENER_LISTA_TODOS_PERMISOS_Result
        {
            public string Codigo { get; set; }
            public string RolCodigo { get; set; }
            public string NombreRed { get; set; }
            public string ProyectoCodigo { get; set; }
            public string Nombre { get; set; }
            public string Estado { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(PermisoTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_LISTA_TODOS_PERMISOS.NombreStoreProcedure;

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_SEG_OBTENER_LISTA_TODOS_PERMISOS_Result> resultadoListaAplicativo = conexion.ObtenerListaDatos<PA_SEG_OBTENER_LISTA_TODOS_PERMISOS_Result>(query);

            objetoTransaccional.ListaPermisos.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Permiso, PA_SEG_OBTENER_LISTA_TODOS_PERMISOS_Result>(resultadoListaAplicativo));
        }
    }
}
