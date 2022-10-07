using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Permisos
{
    public static class ActualizarPermisoDAL
    {
        public static void Execute(PermisoTrx objetoTransaccional)
        {
            string query = PA_SEG_ACTUALIZAR_PERMISOS.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.Codigo, objetoTransaccional.PermisoRequest.Codigo);
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.NombreRed, objetoTransaccional.PermisoRequest.NombreRed);
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.RolCodigo, objetoTransaccional.PermisoRequest.RolCodigo);
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.ProyectoCodigo, objetoTransaccional.PermisoRequest.ProyectoCodigo);
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.Nombre, objetoTransaccional.PermisoRequest.Nombre);
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.Estado, objetoTransaccional.PermisoRequest.Estado);
            parametros.Add(PA_SEG_ACTUALIZAR_PERMISOS.Descripcion, objetoTransaccional.PermisoRequest.Descripcion);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_SEG_ACTUALIZAR_PERMISOS.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPermiso.NoExistePermisoBaseDatos;
            }
        }
    }
}
