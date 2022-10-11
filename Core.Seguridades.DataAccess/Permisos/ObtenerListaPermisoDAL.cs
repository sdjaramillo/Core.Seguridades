using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Permisos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;
using Dapper;


namespace Core.Seguridades.DataAccess.Permisos
{
    public static class ObtenerListaPermisoDAL
    {
        internal class PA_SEG_OBTENER_LISTA_PERMISOS_Result
        {
            public string RolCodigo { get; set; }
            public string RolNombre { get; set; }
            public string NombreRed { get; set; }
            public string NombresUsuario { get; set; }
            public string ApellidosUsuario { get; set; }
            public string ProyectoCodigo { get; set; }
            public string ProyectoNombre { get; set; }
            public string PermisoCodigo { get; set; }
            public string PermisoNombre { get; set; }
        }

        public static void Execute(PermisoTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_LISTA_PERMISOS.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_OBTENER_LISTA_PERMISOS.CodigoProyecto, objetoTransaccional.ProyectoCodigo);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_SEG_OBTENER_LISTA_PERMISOS_Result> resultadoListaAplicativos = conexion.ObtenerListaDatos<PA_SEG_OBTENER_LISTA_PERMISOS_Result>(query, parametros);

            objetoTransaccional.ListaPermisosObtener.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<PermisoDatosGraficos, PA_SEG_OBTENER_LISTA_PERMISOS_Result>(resultadoListaAplicativos));
        }
    }
}
