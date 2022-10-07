

using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;
using Dapper;

namespace Core.Seguridades.DataAccess.Permisos
{
    public static class AgregarPermisoDAL
    {
        internal class PA_SEG_AGREGAR_PERMISOS_Result
        {
            public string Codigo { get; set; }
            public string RolCodigo { get; set; }
            public string NombreRed { get; set; }
            public string ProyectoCodigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
        }

        public static void Execute(PermisoTrx objetoTransaccional)
        {
            string query = PA_SEG_AGREGAR_PERMISOS.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_AGREGAR_PERMISOS.Codigo, objetoTransaccional.PermisoRequest.Codigo);
            parametros.Add(PA_SEG_AGREGAR_PERMISOS.NombreRed, objetoTransaccional.PermisoRequest.NombreRed);
            parametros.Add(PA_SEG_AGREGAR_PERMISOS.RolCodigo, objetoTransaccional.PermisoRequest.RolCodigo);
            parametros.Add(PA_SEG_AGREGAR_PERMISOS.ProyectoCodigo, objetoTransaccional.PermisoRequest.ProyectoCodigo);
            parametros.Add(PA_SEG_AGREGAR_PERMISOS.Nombre, objetoTransaccional.PermisoRequest.Nombre);
            parametros.Add(PA_SEG_AGREGAR_PERMISOS.Descripcion, objetoTransaccional.PermisoRequest.Descripcion);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            conexion.InsertarDatos(query, parametros);

            if (parametros.Get<int>(PA_SEG_AGREGAR_PERMISOS.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPermiso.CamposVaciosPermisoRequest;
            }
        }
    }
}
