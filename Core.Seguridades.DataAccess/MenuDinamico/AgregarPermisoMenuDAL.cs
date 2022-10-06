using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.MenuDinamico
{
    public static class AgregarPermisoMenuDAL
    {
        internal class PA_SEG_AGREGAR_PERMISO_MENU_Result
        {
            public string MenuCodigo { get; set; }
            public string RolCodigo { get; set; }
            public string OpcionMenuCodigo { get; set; }
        }
        public static void Execute(MenusTrx objetoTransaccional)
        {
            string query = PA_SEG_AGREGAR_PERMISO_MENU.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_AGREGAR_PERMISO_MENU.MenuCodigo, objetoTransaccional.PermisoMenuRequest.MenuCodigo);
            parametros.Add(PA_SEG_AGREGAR_PERMISO_MENU.RolCodigo, objetoTransaccional.PermisoMenuRequest.RolCodigo);
            parametros.Add(PA_SEG_AGREGAR_PERMISO_MENU.OpcionMenuCodigo, objetoTransaccional.PermisoMenuRequest.OpcionMenuCodigo);
            parametros.Add(PA_SEG_AGREGAR_PERMISO_MENU.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.InsertarDatos(query, parametros);

            if (parametros.Get<int>(PA_SEG_AGREGAR_PERMISO_MENU.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
                //throw new ExcepcionServicio((int)ErrorAplicativo.NoExisteAplicativoBaseDatos);
            }
        }
    }
}
