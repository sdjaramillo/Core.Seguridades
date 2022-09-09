using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.MenuDinamico;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using Dapper;

namespace Core.Seguridades.DataAccess.MenuDinamico
{
    public static class ObtenerListaMenuRolDAL
    {
        internal class PA_OBTENER_LISTA_MENUS_Result
        {
            public string MenuCodigo { get; set; }
            public string MenuNombre { get; set; }
            public int Nivel { get; set; }
            public string CodigoPadre { get; set; }
            public string Ruta { get; set; }
            public string OpcionMenuCodigo { get; set; }
            public string OpcionMenuNombre { get; set; }
        }

        public static void Execute(MenusTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_MENU_ROL.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_OBTENER_MENU_ROL.NombreRed, objetoTransaccional.MenuRequest.NombreRed);
            parametros.Add(PA_SEG_OBTENER_MENU_ROL.ProyectoCodigo, objetoTransaccional.MenuRequest.ProyectoCodigo);


            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, new DB_Connection().connDB_name);
            List<PA_OBTENER_LISTA_MENUS_Result> resultadoListaMenus = conexion.ObtenerListaDatos<PA_OBTENER_LISTA_MENUS_Result>(query,parametros);

            objetoTransaccional.ListaMenu.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Menu, PA_OBTENER_LISTA_MENUS_Result>(resultadoListaMenus));
        }
    }
}
