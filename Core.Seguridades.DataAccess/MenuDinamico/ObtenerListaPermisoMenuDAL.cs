using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.MenuDinamico;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Seguridades.DataAccess.MenuDinamico
{
    public static class ObtenerListaPermisoMenuDAL
    {
        internal class PA_SEG_OBTENER_PERMISOS_MENU_Result
        {
            public string MenuCodigo { get; set; }
            public string MenuNombre { get; set; }
            public string RolCodigo { get; set; }
            public string RolNombre { get; set; }
            public string OpcionMenuCodigo { get; set; }
            public string OpcionMenuNombre { get; set; }
        }
        public static void Execute(MenusTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_PERMISOS_MENU.NombreStoreProcedure;

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_SEG_OBTENER_PERMISOS_MENU_Result> resultadoListaMenus = conexion.ObtenerListaDatos<PA_SEG_OBTENER_PERMISOS_MENU_Result>(query);

            objetoTransaccional.ListaPermisoMenu.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<PermisoMenuRol, PA_SEG_OBTENER_PERMISOS_MENU_Result>(resultadoListaMenus));
        }
    }
}
