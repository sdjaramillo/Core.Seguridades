using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using Dapper;

namespace Core.Seguridades.DataAccess.MenuDinamico
{
    public static class EliminarPermisoMenuDAL
    {
        public static void Execute(MenusTrx objetoTransaccional)
        {
            string query = PA_SEG_ELIMINAR_PERMISO_MENU.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_ELIMINAR_PERMISO_MENU.MenuCodigo, objetoTransaccional.EliminarPermisoMenuRequest.MenuCodigo);
            parametros.Add(PA_SEG_ELIMINAR_PERMISO_MENU.RolCodigo, objetoTransaccional.EliminarPermisoMenuRequest.RolCodigo);
            parametros.Add(PA_SEG_ELIMINAR_PERMISO_MENU.OpcionMenuCodigo, objetoTransaccional.EliminarPermisoMenuRequest.OpcionMenu);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_SEG_ELIMINAR_PERMISO_MENU.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorMenuRolOpcion.NoExisteMenuBaseDatos;
                //throw new ExcepcionServicio((int)ErrorMenuRolOpcion.NoExisteMenuBaseDatos);
            }
        }
    }
}
